using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScoreUI : MonoBehaviour
{
    [SerializeField] Text highscoretext;

    public void SetHighscore (int score)
    {
        highscoretext.text = score.ToString();
    }
}
