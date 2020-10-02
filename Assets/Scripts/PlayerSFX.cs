using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    public  PlayerDeath playerDeath;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Deadly") && playerDeath.health == 1)
        {
            FindObjectOfType<AudioManager>().Play("Deadly");
        }
        if (collision.CompareTag("Deadly") && playerDeath.health == 2)
        {
            FindObjectOfType<AudioManager>().Play("Deadly");
        }
        if (collision.CompareTag("Deadly") && playerDeath.health == 0)
        {
            FindObjectOfType<AudioManager>().Play("Death");
        }
    }
}
