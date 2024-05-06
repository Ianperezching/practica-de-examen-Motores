using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0; 
    public TMPro.TextMeshProUGUI scoreText;
    public AudioClip audioClip;
    public AudioSource Sonido;

    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore(int points)
    {
        score += points;
        Sonido.Play();
        UpdateScoreText(); 
    }

   
    void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score.ToString();
        
    }
}
