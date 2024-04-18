using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreHandler : MonoBehaviour
{
    [SerializeField] HighScoreUI highScoreUI;
    int highscore;
    
    public int Highscore
    {
        set
        {
            highscore = value;
            highScoreUI.SetHighscore(value);
        }
    }
    private void Start()
    {
        SetLatestHighscore();
    }

    private void SetLatestHighscore()
    {
        Highscore = PlayerPrefs.GetInt("Highscore", 0);
    }

    private void SaveHighscore(int score)
    {
        PlayerPrefs.SetInt("Highscore", score);
    }

    public void SetHighScoreIfGreater(int score)
    {
        if(score > highscore)
        {
            Highscore = score;
            SaveHighscore(score);
            
        }
    }
}
