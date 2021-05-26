using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int scoreValue; //this is the scorevalue

    public Text diceText; //this is the diceText
    


    private void Start()
    {
        diceText.text = scoreValue.ToString(); //displays 0 for startup
    }

    public void AddScore(int pointsToAdd)
    {
        scoreValue += pointsToAdd; //adds scoreValue by the pointsToAdd
        Debug.Log(scoreValue); //prints score to the console
        diceText.text = scoreValue.ToString(); //displays the score onscreen
        AudioManager.instance.PlaySound(AudioManager.instance.collectSound); //plays the appropriate sound

    }
}
