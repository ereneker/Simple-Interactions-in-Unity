using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WritingBoardRotation : MonoBehaviour
{
    [SerializeField]
    public GameObject writingBoard;
    [SerializeField]
    public GameObject TriggerText;
    float tiltAngle = 60.0f;
    bool isGameObjectTriggered;    

    void Start()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 90);
        TriggerText.gameObject.SetActive(false);
        isGameObjectTriggered = false;
    }
    private void OnTriggerStay(Collider Player)
    {
        TriggerText.gameObject.SetActive(true);
        if (Player.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            if (isGameObjectTriggered == false)
            {
                writingBoard.transform.Rotate(new Vector3(0, 0, 180f));
                writingBoard.transform.position = new Vector3(-3.989f, 2.663f, 2.899f);
                isGameObjectTriggered = true;
            }
        }
        else if (Player.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            if (isGameObjectTriggered == true)
            {
                writingBoard.transform.Rotate(new Vector3(0, 0, 0));
                writingBoard.transform.position = new Vector3(-3.989f, 1.63f, 2.899f);
                isGameObjectTriggered = false;
            }
        }
    }
    private void OnTriggerExit(Collider Player)
    {
        TriggerText.gameObject.SetActive(false);
    }
}
