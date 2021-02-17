using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int score;

    private static ScoreController _instance;

    public TextMeshProUGUI scoreText;
    public static ScoreController Instance => _instance;


    private void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void HitHole()
    {
        score++;
    }

    public void HitBoard()
    {
        
    }

    public void MissBoard()
    {
        
    }

    public void ResetScore()
    {
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    
}
