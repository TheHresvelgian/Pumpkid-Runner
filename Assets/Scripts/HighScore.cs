using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    
    private void Awake()
    {
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        for (int i = 0; i < 5; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -entryTemplate.position.y * i);
            entryTransform.gameObject.SetActive(true);

            int rank = i + 1;
            string rankString;
            switch (rank)
            {
                default:
                    rankString = rank + "TH"; break;
                case 1: rankString = "1ST"; break;
                case 2: rankString = "2ND"; break;
                case 3: rankString = "3RD"; break;
            }
            entryTransform.Find("Number").GetComponent<Text>().text = rankString;
            entryTransform.Find("Score").GetComponent<Text>().text = PickUpScript.score.ToString("0"); ;
            entryTransform.Find("Name").GetComponent<Text>().text = "Name";
        }
    }
    private class HighscoreEntry
    {
        public int score;
        public string name;
    }
}
