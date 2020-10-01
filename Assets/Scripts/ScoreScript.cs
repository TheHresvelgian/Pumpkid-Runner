using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text finalScore;
    public GameObject player;
    public int scoreD;
    private void Start()
    {
       scoreD = player.GetComponent<PickUpScript>().score;
    }
    private void Update()
    {
        scoreD = player.GetComponent<PickUpScript>().score;
        finalScore.text = scoreD.ToString("0");
    }

}
