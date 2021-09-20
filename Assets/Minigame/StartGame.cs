using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    private bool PanelMenu = false;
    private void OnTriggerStay(Collider Player)
    {
        if (GetComponent<Renderer>().isVisible)
        {
            ball1.SetActive(false);
            ball2.SetActive(false);
            ball3.SetActive(false);
        }
        else
        {
            ball1.SetActive(true);
            ball2.SetActive(true);
            ball3.SetActive(true);
        }
    }
}
