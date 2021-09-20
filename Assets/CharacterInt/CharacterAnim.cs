using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterAnim : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider Player)
    {
        if (Input.GetKeyDown(KeyCode.Q) && Player.tag=="Player")
        {
            animator.Play("male_emotion_laugh_on_chair");
        }
    }
}