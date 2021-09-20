using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelVisible : MonoBehaviour
{
    public GameObject CanvasMenu;
    private bool PanelMenu = false;
    [SerializeField]
    private Text MenuText;
    bool inTrigger = false;
    private GameObject RollerBall1;
    [SerializeField]
    public TextMeshProUGUI countText;

    void Start()
    {
        MenuText.gameObject.SetActive(false);
        countText.gameObject.SetActive(false);
    }
    private void OnTriggerStay(Collider Player)
    {
        if (Player.tag == "Player")
        {
            MenuText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && !PanelMenu)
            {
                CanvasMenu.SetActive(true);
                Cursor.visible = true;
            }
            if (CanvasMenu.activeInHierarchy)
            {
                MenuText.gameObject.SetActive(false);
            }
            if(RollerBall1.activeInHierarchy)
            {
                MenuText.gameObject.SetActive(false);
                countText.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider Player)
    {
        if(Player.tag=="Player" && !PanelMenu)
        {
            MenuText.gameObject.SetActive(false);
        }
    }
}
