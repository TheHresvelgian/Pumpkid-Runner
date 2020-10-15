using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScore;
 
   
    private void Update ()
    { 
        finalScore.text = PickUpScript.score.ToString("0");
    }
}
