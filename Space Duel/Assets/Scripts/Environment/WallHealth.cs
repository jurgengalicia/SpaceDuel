using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//added a wall between the two players
public class WallHealth : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D collision){
    gameObject.SetActive(false);
  }
}
