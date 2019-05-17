using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonBlast : MonoBehaviour
{
    void Update()
    {
        if(Input.GetButtonDown("NextRound"))
          Destroy(gameObject);
    }

    //points would be recieved when coins are shot by the player.
    //fix: added tags on coins so only players can pick them up
    private void OnTriggerExit2D(Collider2D collider){
      if(collider.gameObject.tag != "CoinPickup")
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.tag != "PhotonBlast")
        Destroy(gameObject);
    }
}
