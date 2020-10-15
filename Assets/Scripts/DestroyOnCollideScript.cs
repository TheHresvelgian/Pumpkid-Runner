using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollideScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CandyCorn"))
        {

            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Lollipop"))
        {

            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Schmores"))
        {

            Destroy(other.gameObject);
        }
        else if (other.CompareTag("KvikkLunsj"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Deadly"))
        {

            Destroy(other.gameObject);

        }
        else if (other.CompareTag("Heal"))
        {
            Destroy(other.gameObject);

        }
        else if (other.CompareTag("Tutorial"))
        {
            Destroy(other.gameObject);

        }
    }
}
