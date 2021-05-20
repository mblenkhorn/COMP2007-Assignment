using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int Score;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        scoreText.text = Score.ToString();
    }

    public void AddScore(int pointsToAdd)
    {
        Score += pointsToAdd;
        Debug.Log(Score);
        scoreText.text = Score.ToString();
    }
}
