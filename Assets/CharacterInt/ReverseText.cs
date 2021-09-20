using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseText : MonoBehaviour
{
    private void OnTriggerStay(Collider Player)
    {
        if (Player.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Renderer>().material.SetTextureScale("Level_objects_mat", new Vector2(-1, 1));
        }
    }
}
