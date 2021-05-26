using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float startingTime = 100.0f; //this is the starting time 

    public Slider eggTimer; //a reference to the slider

    public GameObject endPanel; //a reference to the endPanel

    public static bool isStopped; //checks whether time is stopped or not

    private void Start()
    { 
        eggTimer = GetComponent<Slider>(); //gathers the slider component
    }

    private void Update()
    {
        Countdown(); //runs this function
    }

    public void Countdown()
    {
        if (!isStopped) //if time hasn't stopped
        {
            startingTime -= Time.deltaTime; //deplete the startingtime (frame independent)
            eggTimer.value = startingTime; //assign startingtime to the eggtime.value
        }
       

        if(startingTime <= 0) //if less than zero
        {
            startingTime = 0; //set the time to zero
            isStopped = true; //set the isStopped to true
            endPanel.SetActive(true); //enable the endpanel
        }
    }


}
