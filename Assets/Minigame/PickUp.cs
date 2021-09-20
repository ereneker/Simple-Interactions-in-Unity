using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp: MonoBehaviour
{

    public Transform handPos;
    public string playerTag;
    public GameObject Arm;
    public bool canPickUp;
    public bool pickedUp;
    public Vector3 offset;

    void Start()
    {

    }

    void Update()
    {
        if (pickedUp == true)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            gameObject.transform.position = handPos.position + offset;
            gameObject.transform.parent = null;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }

        if (canPickUp == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                pickedUp = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            pickedUp = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.transform.parent = null;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == playerTag)
        {
            Debug.Log("Player Entered Trigger. Trigger is valid.");
            canPickUp = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == playerTag)
        {
            canPickUp = false;
        }
    }
}