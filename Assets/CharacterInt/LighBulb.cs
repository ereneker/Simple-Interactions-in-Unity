using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LighBulb : MonoBehaviour
{
    [SerializeField]
    private Text LightTextOpen;
    [SerializeField]
    private Text LightTextClose;
    public GameObject desk_lump;
    private bool on = false;

    void Start()
    {
        LightTextOpen.gameObject.SetActive(false);
        LightTextClose.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider player){
        if (desk_lump.activeInHierarchy)
        {
            LightTextOpen.gameObject.SetActive(false);
            LightTextClose.gameObject.SetActive(true);
        }
        else
        {
            LightTextOpen.gameObject.SetActive(true);
            LightTextClose.gameObject.SetActive(false);
        }
        if (player.tag=="Player" && Input.GetKeyDown(KeyCode.E) && !on){
            LightTextOpen.gameObject.SetActive(true);
            LightTextClose.gameObject.SetActive(false);
            desk_lump.SetActive(true);
            on = true;
        }else if(player.tag=="Player" && Input.GetKeyDown(KeyCode.E) && on){
            LightTextOpen.gameObject.SetActive(false);
            LightTextClose.gameObject.SetActive(true);
            desk_lump.SetActive(false);
            on = false;
        }
    }
    private void OnTriggerExit(Collider player)
    {
        if (player.tag == "Player")
        {
            LightTextOpen.gameObject.SetActive(false);
            LightTextClose.gameObject.SetActive(false);
        }
    }
}
