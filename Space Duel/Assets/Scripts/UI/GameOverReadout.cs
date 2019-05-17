using UnityEngine;
using UnityEngine.UI;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//game over screen pops up when either player gets to 10 points
public class GameOverReadout : MonoBehaviour
{
    Text gameOverText;
    public ScoreObject score;
    // Start is called before the first frame update
    void Start()
    {
      gameOverText = GetComponent<Text>();
      gameOverText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
      if(score.playerOne == 10)
        gameOverText.text = "Player One Wins!";
      else if(score.playerTwo == 10)
        gameOverText.text = "Player Two Wins!";
    }
}
