using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public static bool gameIsPaused = false;
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
    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        PickUpScript.score = 0;
        Resume();

        Time.timeScale = 1f;
    }
    public void HighScoreScreen()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Resume()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        gameIsPaused = false;
    }
}
