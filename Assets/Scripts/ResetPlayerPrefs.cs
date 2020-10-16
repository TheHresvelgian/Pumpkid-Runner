using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Input.GetKeyDown(KeyCode.T))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
