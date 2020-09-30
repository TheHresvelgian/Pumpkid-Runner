using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public int _score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CandyCorn"))
        {
            _score = _score+1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Lollipop"))
        {
            _score = _score+3;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Schmores"))
        {
            _score = _score+5;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("KvikkLunsj"))
        {
            _score = _score+10;
            Destroy(other.gameObject);
        }
    }
    private void FixedUpdate()
    {
        print(_score);
    }
}
