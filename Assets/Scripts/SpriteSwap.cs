using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwap : MonoBehaviour
{
    public Sprite lowHealth; // Displaying sprite for low health.
    public Sprite mediumHealth; // Displaying sprite for medium health.
    public Sprite fullHealth; // Displaying sprite for full health
    public Sprite noHealth;
    public PlayerDeath playerDeath;



    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // Grab your sprite renderer from your GameObject.
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    private void Update ()
    {
        if (playerDeath.health == 0)
        {
            spriteRenderer.sprite = noHealth;
        }
        if (playerDeath.health == 1)
        {
            spriteRenderer.sprite = lowHealth;
        }
        else if (playerDeath.health == 2)
        {
            spriteRenderer.sprite = mediumHealth;
        }
        else if (playerDeath.health == 3)
        {
            spriteRenderer.sprite = fullHealth;
        }
    }
}
