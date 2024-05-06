using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0; 
    public TMPro.TextMeshProUGUI scoreText; 

    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore(int points)
    {
        score += points; 
        UpdateScoreText(); 
    }

   
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); 
    }
}
