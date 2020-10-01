using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScore;
 //   PickUpScript pickUp;
  //  public int scoreD = PickUpScript._score;
   
    private void Update ()
    {
        // finalScore.text = pickUp.score.ToString("0");
        finalScore.text = PickUpScript.score.ToString("0");
    }
}
