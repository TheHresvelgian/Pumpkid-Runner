using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public int health = 3;

    private void Update()
    {
        if (health <= 0)
        {
            Invoke("Death", 2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Deadly"))
        {
            health --;
            collision.GetComponent<Collider2D>().enabled = false;
        }
       else  if (collision.CompareTag("Heal"))
        {
            FindObjectOfType<AudioManager>().Play("Heal");
            health = 3;
            Destroy(collision.gameObject);
           
        }
      
       
    }
    
   public void Death ()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        HighscoreTable.AddHighscoreEntry(PickUpScript.score, PlayerPrefs.GetString("name"));
    }
}
