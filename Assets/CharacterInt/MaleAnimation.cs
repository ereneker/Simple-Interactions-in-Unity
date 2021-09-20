using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaleAnimation : MonoBehaviour
{
    [SerializeField]
    public GameObject male = null;
    private bool isInsideTrigger = false;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Text AnimationText;
    private bool isOpen = false;

    void Start()
    {
        male.SetActive(true);
        AnimationText.gameObject.SetActive(false);
    }
    private void OnTriggerStay(Collider Player)
    {
        if (Player.tag == "Player")
        {
            isInsideTrigger = true;
            male.SetActive(true);
            AnimationText.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider Player)
    {
        if (Player.tag == "Player")
        {
            isInsideTrigger = false;
            AnimationText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOpen = !isOpen;

                animator.SetBool("Anims", isOpen);
            }
        }
    }
}
