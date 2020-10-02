using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("DeathScreenTheme");
        Cursor.visible = true;
    }
    public void LoadMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        
    }

    public void QuitGame()
    {
        print("Hey");
        FindObjectOfType<AudioManager>().Play("Click");
        Application.Quit();
    }
}
