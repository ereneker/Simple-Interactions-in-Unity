using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ItemPickUp : MonoBehaviour
{
    private Rigidbody rb;
    public Rigidbody Rb => rb;
    private void awake()
    {
        rb = GetComponent<Rigidbody>();
    }
}
