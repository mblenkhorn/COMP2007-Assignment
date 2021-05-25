using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float startingTime = 100.0f;

    public Slider eggTimer;

    public GameObject endPanel;

    private void Start()
    {
        eggTimer = GetComponent<Slider>();
    }

    private void Update()
    {
        Countdown();
    }

    public void Countdown()
    {
        startingTime -= Time.deltaTime;
        eggTimer.value = startingTime;

        if(startingTime <= 0)
        {
            startingTime = 0;
            endPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}
