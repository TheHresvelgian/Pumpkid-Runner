using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Deadly") || coll.CompareTag("CandyCorn") || coll.CompareTag("KvikkLunsj") || coll.CompareTag("Lollipop") || coll.CompareTag("Schmores"))
        {
            Destroy(coll.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Deadly") || coll.gameObject.CompareTag("CandyCorn") || coll.gameObject.CompareTag("KvikkLunsj") || coll.gameObject.CompareTag("Lollipop") || coll.gameObject.CompareTag("Schmores"))
        {
            Destroy(coll.gameObject);
        }
    }
}
