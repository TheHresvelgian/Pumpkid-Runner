using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PickUpScript.score = 0;
        
        Time.timeScale = 1f;
       
    }
    public void QuitGame()
    {
        print("Hey");
        Application.Quit();
    }
}
