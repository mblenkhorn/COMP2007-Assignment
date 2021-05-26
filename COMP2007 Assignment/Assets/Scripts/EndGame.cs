using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public ScoreManager manager; //a reference to the scoremanager
    public GameObject menuPanel; //this is the panel that appears when the game is over

    public Text scoreText; //shows the player their score

    public DiceBlock block; //a reference to the diceblock

    public Text congratsText; //displays this text - changes depending on the amount of blocks collected

    //these are audiosources to be stopped when game is over
    public AudioSource music;
    public AudioSource timer;

    private void Update()
    {
        if(manager.scoreValue == 24 || Timer.isStopped == true) //if the scorevalue equals 24 and timer is stopped
        {
            StopTime(); //run this time
            menuPanel.SetActive(true); //enable visibility of panel
            CalcuateScore(); //run this function
            //stop the sounds
            music.Stop();
            timer.Stop();
            //run this function
            ExitGame();

        }
        

        if(manager.scoreValue == 24)
        {
            congratsText.text = "Congratulations! You've collected all the Dice Blocks!";
        }
        else
        {
            congratsText.text = "Good Job!";
        }

        
    }

    public void StopTime()
    {
        Time.timeScale = 0f; //stops time
    }


    public void CalcuateScore()
    {
        int score = manager.scoreValue * 5; //multiply the score by 5 and store it in the score variable
        scoreText.text = score.ToString(); //display the score
    }

    public void ExitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }
}