using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    TextMeshProUGUI _scoretext;
    private void Awake()
    {
        _scoretext = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;
    }

    private void OnDisable() //GameManager statik bir object olduğu için içindeki hiçbir değeri atmayacağından şişme yapmasın diye oyun kapandığında değeri silecektir
    {
        GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged; 
    }

    private void HandleOnScoreChanged(int score = 0)
    {
        _scoretext.text = "Skor: " + score;
    }
}
