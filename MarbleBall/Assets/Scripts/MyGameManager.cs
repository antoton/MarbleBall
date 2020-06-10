﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public GameObject nextLevelCanvas;

    private Health healthPlayer;

    public enum GameStates {
        Playing,
        GameOver,
        Completed
    }
    public GameStates gameState = GameStates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        if (player == null) {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive) 
                {
                    gameState = GameStates.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }
                break;
            case GameStates.Completed: 
                mainCanvas.SetActive(false);
                nextLevelCanvas.SetActive(true);
                break;
                     
        }
    }
}
