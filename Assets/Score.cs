﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text textObject;

    public void UpdateScore()
    {
        Debug.Log(score);
        score = score + 1;
        textObject.text = "Score:" + score;
    }
}
