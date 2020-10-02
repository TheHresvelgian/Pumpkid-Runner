using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteSwap : MonoBehaviour
{
    public Sprite lowHealth; // Displaying sprite for low health.
    public Sprite mediumHealth; // Displaying sprite for medium health.
    public Sprite fullHealth; // Displaying sprite for full health
    public PlayerDeath playerDeath;
    private Animator animator;
    
    

    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        // Grab your sprite renderer from your GameObject.
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }

    

    private void Update ()
    {
        
        if (playerDeath.health == 1)
        {
            animator.SetInteger("health", 1);
            
        }
        else if (playerDeath.health == 2)
        {

            animator.SetInteger("health", 2);
            
        }
        else if (playerDeath.health == 3)
        {
            animator.SetInteger("health", 3);

        }
        if (playerDeath.health == 0)
        {
            FindObjectOfType<AudioManager>().Play("Death");
            animator.SetInteger("health", 0);
        }
    }
}
