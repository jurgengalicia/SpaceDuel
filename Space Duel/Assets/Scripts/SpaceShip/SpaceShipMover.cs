using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMover : MonoBehaviour
{
    ConstantForce2D force;
    public float thrust;
    public float alpha;

    // Start is called before the first frame update
    void Start(){
        force = GetComponent<ConstantForce2D>();
    }

    private void movePlayer(string horizontal, string vertical){
      force.torque = Input.GetAxis(horizontal) * alpha;
      force.relativeForce = new Vector2 (0.0f, Input.GetAxis(vertical) * thrust);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.name.EndsWith("One", System.StringComparison.Ordinal))
          movePlayer("HorizontalPlayerOne", "VerticalPlayerOne");
        else
          movePlayer("HorizontalPlayerTwo", "VerticalPlayerTwo");
    }
}
