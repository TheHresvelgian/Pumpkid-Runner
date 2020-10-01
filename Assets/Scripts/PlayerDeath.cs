using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public int health = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Deadly"))
        {
           health --;
            print("deadly");
        }
       else  if (collision.CompareTag("Heal"))
        {
            health = 3;
            Destroy(collision.gameObject);
            print("health");
        }
       
    }
    
    public void Death ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
