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
}
