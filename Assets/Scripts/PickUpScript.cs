using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public static int score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CandyCorn"))
        {
            FindObjectOfType<AudioManager>().Play("CandyCorn");
            score = score+1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Lollipop"))
        {
            FindObjectOfType<AudioManager>().Play("Lollipop");
            score = score+3;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Schmores"))
        {
            FindObjectOfType<AudioManager>().Play("Schmores");
            score = score+5;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("KvikkLunsj"))
        {
            FindObjectOfType<AudioManager>().Play("KvikkLunsj");
            score = score+10;
            Destroy(other.gameObject);
        }
    }
    private void FixedUpdate()
    {
       // print(_score);
    }
}
