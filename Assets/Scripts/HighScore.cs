using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;

    [SerializeField] float templateheight = 20f;

    
    private List<Transform> highscoreEntryTransformList;

    public void AddHighScoreEntry(int score, string playerName)
    {
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = PickUpScript.score, playerName = PlayerPrefs.GetString("name") };

        string jsonString = PlayerPrefs.GetString("HighScoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        highscores.highscoreEntryList.Add(highscoreEntry);
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("HighScoreTable", json);
        PlayerPrefs.Save();
    }

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("MainScreenTheme");
    }

    private void Awake()
    {

 
        FindObjectOfType<AudioManager>().Play("MainScreenTheme");
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        AddHighScoreEntry(PickUpScript.score, PlayerPrefs.GetString("name"));



        string jsonString = PlayerPrefs.GetString("HighScoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    // Swap
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;
                }
            }
        }

        highscoreEntryTransformList = new List<Transform>();

        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            CreateHighScoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }

        
    }
    private void CreateHighScoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateheight * transformList.Count);
        if (transformList.Count < 5)
        {
            entryTransform.gameObject.SetActive(true);
        }

       

        int rank = transformList.Count + 1;
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
        entryTransform.Find("Score").GetComponent<Text>().text = highscoreEntry.score.ToString("0"); ;
        entryTransform.Find("Name").GetComponent<Text>().text =  highscoreEntry.playerName;

        entryTransform.Find("Background").gameObject.SetActive(rank % 2 == 1);
        transformList.Add(entryTransform);
        
      
    }

    

    private class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList;
    }

    [System.Serializable]
    private class HighscoreEntry
    {
        public int score;
        public string playerName;
    }
}
