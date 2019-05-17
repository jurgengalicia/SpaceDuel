using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//added 4 coin pickups for the players.
//each coin is worth 1 point
public class CoinScript : MonoBehaviour
{
    public ScoreObject score;

    private void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Player"){
        if(collision.gameObject.name == "PlayerOne")
          score.playerOne++;
        else if(collision.gameObject.name == "PlayerTwo")
          score.playerTwo++;
        gameObject.SetActive(false);
      }
    }
}
