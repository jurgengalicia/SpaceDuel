using UnityEngine;
using UnityEngine.UI;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReadout : MonoBehaviour
{
    Text scoreText;
    public ScoreObject score;
    // Start is called before the first frame update
    void Start()
    {
      scoreText = GetComponent<Text>();
      scoreText.text = "0:0";
    }

    // Update is called once per frame
    void Update()
    {
      scoreText.text = score.playerOne + ":" + score.playerTwo;
    }
}
