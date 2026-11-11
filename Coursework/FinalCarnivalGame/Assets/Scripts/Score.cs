using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public TMP_Text Score_UI;

    private int Ball_Score;

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
        Ball_Score++;
        Score_UI.text = "Score: " + Ball_Score;
    }

    private void Awake()
    {
       Instance = this;
    }

}
