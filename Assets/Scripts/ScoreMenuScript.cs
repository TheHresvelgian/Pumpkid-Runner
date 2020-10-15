using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreMenuScript : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public void LoadMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        
        Cursor.visible = true;

    }

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        PickUpScript.score = 0;
        Resume();

        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        print("Hey");
        FindObjectOfType<AudioManager>().Play("Click");
        Application.Quit();
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        gameIsPaused = false;
    }
}
