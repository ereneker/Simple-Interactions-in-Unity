using UnityEngine;

public class CharacterItemPickup : MonoBehaviour
{
    [SerializeField]
    private Camera characterCamera;

    // Reference for hand holds item
    [SerializeField]
    private Transform slot;
    // Reference for item that picked up
    private PickableItem pickedItem;
    // Reference for the inventory UI
    [SerializeField]
    public GameObject UIItem;


    void Start()
    {
        UIItem.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Check if player picked some item already
            if (pickedItem)
            {
                DropItem(pickedItem);
            }
            else
            {
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                //Raycast detection of object
                if (Physics.Raycast(ray, out hit, 1.5f))
                {
                    var pickable = hit.transform.GetComponent<PickableItem>();

                    if (pickable)
                    {
                        PickItem(pickable);

                    }
                }
            }
        }
    }
    private void PickItem(PickableItem item)
    {
        pickedItem = item;
        //Ignore rigidbody
        item.Rb.isKinematic = true;

        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;
        item.transform.SetParent(slot);
        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;

        UIItem.gameObject.SetActive(true);
    }
    private void DropItem(PickableItem item)
    {
        pickedItem = null;
        item.transform.SetParent(null);
        item.Rb.isKinematic = false;
        item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
        UIItem.gameObject.SetActive(false);
    }
}