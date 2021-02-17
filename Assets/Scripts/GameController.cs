using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private static GameController _instance;

    public static GameController Instance => _instance;

    public CanvasGroup winScreen, loseScreen;
    public GameObject board;
    private void Awake()
    {
        _instance = this;
    }
    

    public void WinGame()
    {
        winScreen.enabled = true;
    }

    public void LoseGame()
    {
        loseScreen.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (ScoreController.Instance.score == 21)
        {
            WinGame();
        }

      
    }

    public void ResetGame()
    {
        ScoreController.Instance.ResetScore();
        BagController.Instance.ResetBag();
    }

    public void MoveBoard(float pos)
    {
        board.transform.position = new Vector3(board.transform.position.x, 0, pos);
    }
}
