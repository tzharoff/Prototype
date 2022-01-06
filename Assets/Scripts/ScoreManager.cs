using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text healthText;
    [SerializeField] private int Lives = 3;
    [SerializeField] private GameObject LosePanel;

    private int score;



    private void OnEnable()
    {
        Coin.CoinCollect += AddScore;
        Hazard.HitHazard += RemoveHealth;
    }

    private void OnDisable()
    {
        Coin.CoinCollect -= AddScore;
        Hazard.HitHazard -= RemoveHealth;
    }

    public void AddScore()
    {
        score++;
        //score = score + 1;
        scoreText.text = "SCORE: " + score.ToString();
    }
    private void RemoveHealth()
    {
        Lives--;
        //Lives = Lives - 1;
        if(Lives <= 0)
        {
            LosePanel.SetActive(true);
        }
        healthText.text = "HEALTH: " + Lives.ToString();
    }
}
