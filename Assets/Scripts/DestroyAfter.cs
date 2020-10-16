using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyAfter : MonoBehaviour
{
    public Text text;
    private string control = "Use W to move up \n" +
        "S to move down\n" +
        "A to slow down\n" +
        "D to speed up";
    private string health = "The pumpkin is your health bar\n" +
        "you have three lives";
    private string heal = "The bags of fertilizer\n restore your health";
    void Start()
    {
        text.text = control;
        Invoke("Health", 4f);

    }
    void Health ()
    {
        text.text = health;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Heal"))
        {
            text.text = heal;
            Invoke("Destroy", 3f);
        }
    }
    void Heal ()
    {
        text.text = heal;
    }
    private void Destroy()
    {
        Object.Destroy(this.gameObject);
    }
}
