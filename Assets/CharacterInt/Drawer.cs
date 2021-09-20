using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawer : MonoBehaviour
{
    [SerializeField]
    public GameObject lp_cabinet_door3 = null;
    private bool isInsideTrigger = false;
    [SerializeField]
    private Animator animator;
    public Text DrawerOpenClose;
    private bool isOpen = false;

    void Start()
    {
        DrawerOpenClose.gameObject.SetActive(false);
    }
    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            isInsideTrigger = true;
            lp_cabinet_door3.SetActive(true);
            DrawerOpenClose.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            isInsideTrigger = false;
            DrawerOpenClose.gameObject.SetActive(false);
        }
    }
    private bool IsOpenPanelActive
    {
        get
        {
            return lp_cabinet_door3.activeInHierarchy;
        }
    }

    void Update()
    {
        if(IsOpenPanelActive && isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOpen = !isOpen;

                animator.SetBool("PlayDrawer", isOpen);
            }
        }
    }
}
