using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public int score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CandyCorn"))
        {
            score = score+1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Lollipop"))
        {
            score = score+3;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Schmores"))
        {
            score = score+5;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("KvikkLunsj"))
        {
            score = score+10;
            Destroy(other.gameObject);
        }
    }
    private void FixedUpdate()
    {
       // print(_score);
    }
}
