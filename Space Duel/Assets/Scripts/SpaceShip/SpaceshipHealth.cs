using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipHealth : MonoBehaviour
{
    public ScoreObject score;

    private void ApplyDamage(){
      gameObject.SetActive(false);
      if(gameObject.name.EndsWith("One", System.StringComparison.Ordinal))
        score.playerTwo++;
      else
        score.playerOne++;
    }

    private void OnCollisionEnter2D(Collision2D collision){
      ApplyDamage();
    }

    //removed on trigger exit to fix recieving two points when enemy
    //player is killed with cannons
    //fix: created wall boundary for ships to collide to and get destroyed

}
