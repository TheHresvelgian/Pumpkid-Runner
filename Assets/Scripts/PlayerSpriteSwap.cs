using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteSwap : MonoBehaviour
{
    public Sprite lowHealth; // Displaying sprite for low health.
    public Sprite mediumHealth; // Displaying sprite for medium health.
    public Sprite fullHealth; // Displaying sprite for full health
    public PlayerDeath playerDeath;
    
    

    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        // Grab your sprite renderer from your GameObject.
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    

    private void Update ()
    {
        
        if (playerDeath.health == 1)
        {
            spriteRenderer.sprite = lowHealth;
        }
        else if (playerDeath.health == 2)
        {
            spriteRenderer.sprite = mediumHealth;
        }
        else
        {
            spriteRenderer.sprite = fullHealth;
        }
    }
}
