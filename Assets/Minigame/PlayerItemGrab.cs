using UnityEngine;


public class PlayerItemGrab : MonoBehaviour
{
    [SerializeField]
    private Camera characterCamera;
    [SerializeField]
    private Transform slot;
    private ItemPickUp pickedItem;  

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (pickedItem)
            {
                DropItem(pickedItem);
            }
            else
            {
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1.5f))
                {
                    var pickable = hit.transform.GetComponent<ItemPickUp>();

                    if (pickable)
                    {
                        PickItem(pickable);
                    }
                }
            }
        }
    }

    private void PickItem(ItemPickUp item)
    {
        pickedItem = item;

        item.Rb.isKinematic = false;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;

        item.transform.SetParent(slot);

        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;
    }

    private void DropItem(ItemPickUp item)
    {
 
        pickedItem = null;

        item.transform.SetParent(null);

        item.Rb.isKinematic = true;

        item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
    }
}