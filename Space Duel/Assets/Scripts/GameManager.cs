using UnityEngine;
using UnityEngine.UI;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerOne, spawnPointOne, playerTwo, spawnPointTwo, gameWall, gameCoins, gameOverText;
    Text WinningText;
    public ScoreObject score;
    // Start is called before the first frame update

    private void resetPlayer(GameObject player, GameObject spawnPointPlayer){
      player.transform.SetPositionAndRotation(spawnPointPlayer.transform.position,
                                                  spawnPointPlayer.transform.rotation);
      Rigidbody2D rigidBody = player.GetComponent<Rigidbody2D>();
      rigidBody.velocity = Vector2.zero;
      rigidBody.angularVelocity = 0.0f;
      player.SetActive(true);
    }

    private void resetEnvironments(){
      if(WinningText.text != "")
        WinningText.text = "";
      gameWall.SetActiveRecursively(true);
      gameCoins.SetActiveRecursively(true);
    }

    private void newGame(){
      resetEnvironments();
      newRound();
      score.playerOne = score.playerTwo = 0;
    }

    private void newRound(){
      resetPlayer(playerOne, spawnPointOne);
      resetPlayer(playerTwo, spawnPointTwo);
    }

    private void handleInput(){
      if(Input.GetButtonDown("NewGame"))
        newGame();

      if(Input.GetButtonDown("NextRound"))
        newRound();
    }

    void Start(){
      score.playerOne = score.playerTwo = 0;
      WinningText = gameOverText.GetComponent<Text>();
      spawnPointOne.transform.SetPositionAndRotation(playerOne.transform.position,
                                                  playerOne.transform.rotation);
      spawnPointTwo.transform.SetPositionAndRotation(playerTwo.transform.position,
                                                  playerTwo.transform.rotation);
    }

    // Update is called once per frame
    void Update(){
      handleInput();

    }
}
