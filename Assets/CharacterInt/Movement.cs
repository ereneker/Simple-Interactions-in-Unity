using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public AudioSource PlayerAudioSource1;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0, 0,-speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-speed*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(speed*Time.deltaTime, 0, 0);
        }
        void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("metal_sink")){
            GetComponent<Rigidbody>().velocity=Vector3.zero;
        }
    }
    if(Input.GetKey(KeyCode.W)){
              if(!PlayerAudioSource1.isPlaying)  {PlayerAudioSource1.Play();}
         } else {
             PlayerAudioSource1.Stop();
          }
  
         if(Input.GetKey(KeyCode.S))
          {
             if(!PlayerAudioSource1.isPlaying)    {PlayerAudioSource1.Play();}
          } else {
             PlayerAudioSource1.Stop();
             }

    }
}
