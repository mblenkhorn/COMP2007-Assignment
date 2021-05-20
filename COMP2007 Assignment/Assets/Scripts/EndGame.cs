using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public ScoreManager manager;
    public GameObject menuPanel;

    private void Update()
    {
        if(manager.Score == 20)
        {
            Time.timeScale = 0f;
            menuPanel.SetActive(true);

        }
    }



}
