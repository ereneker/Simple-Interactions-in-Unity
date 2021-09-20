using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    private int count;
    [SerializeField]
    public TextMeshProUGUI countText;
    [SerializeField]
    public GameObject RollerBall;

    void Start()
    {
        count = 0;
        UpdateScore(0);
    }
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Ball"){
            UpdateScore(1);
        }
    }

    void UpdateScore(int scoreToAdd)
    {
        count += scoreToAdd;
        countText.text = "Ball Count: " + count;
    }
}
