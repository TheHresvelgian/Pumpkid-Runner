using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNameScript : MonoBehaviour
{
    public  static string nameOfPlayer;
    public  string saveName;

    public  Text inputText;
    public  Text loadedName;

    public void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name");
        loadedName.text = nameOfPlayer;
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SetName();
        }
    }

    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
        
    }
}
