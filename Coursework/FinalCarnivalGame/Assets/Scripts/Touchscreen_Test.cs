using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Touchscreen_Test : MonoBehaviour
{
    public TMP_Text tempScore;

    private int Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        Score++;
        tempScore.text = "Score: " + Score;
    }

}
