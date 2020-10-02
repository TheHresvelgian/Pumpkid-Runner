using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    public  PlayerDeath playerDeath;

    public AudioClip _death;
    private AudioSource _source;

    private bool _canDie = true;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }
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
            //FindObjectOfType<AudioManager>().Play("Death");
            if (_canDie)
            {
                _source.PlayOneShot(_death);
                _canDie = false;
            }
           
        }
    }
}
