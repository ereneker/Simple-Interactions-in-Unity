using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RescaleObject : MonoBehaviour
{
    Vector3 temp;

    void Start()
    {
        temp = transform.localScale;
        temp.x *=1.5f;
        temp.y *=1.5f;
        temp.z *=1.5f;

        transform.localScale = temp;
    }
}