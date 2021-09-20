using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
     private enum collideTrigger
 {
     trigger,
     collider
 }
 private collideTrigger cTrigger;
 private Collider col;
 // Use this for initialization
 void Start () {
     col = GetComponent<Collider>();
     if (col.isTrigger)
     {
         cTrigger = collideTrigger.trigger;
     }
     else
     {
         cTrigger = collideTrigger.collider;
     }
 }
 private void OnTriggerEnter(Collider other)
 {
     if (cTrigger == collideTrigger.trigger)
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
 }
 private void OnCollisionEnter(Collision collision)
 {
     if (cTrigger == collideTrigger.collider)
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
 }
}
