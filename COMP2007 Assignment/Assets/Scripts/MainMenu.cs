using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject controlsMenu;
    public GameObject aboutMenu;
    public GameObject mainMenu;

    public bool isControlMenu;
    public bool isAboutMenu;
    public bool isMainMenu;

    public void Start()
    {
        isMainMenu = true;
    }



    public void StartGame()
    {
        SceneManager.LoadScene("StreetScene");
    }

    public void OpenControlsMenu()
    {
        if(isMainMenu || isAboutMenu)
        {
            isMainMenu = false;
            isAboutMenu = false;
            isControlMenu = true;
        }

        if (isControlMenu)
        {
            controlsMenu.SetActive(true);
            mainMenu.SetActive(false);
        }

    }

    public void OpenAboutMenu()
    {
        if (isMainMenu || isControlMenu)
        {
            isMainMenu = false;
            isControlMenu = false;
            isAboutMenu = true;
        }

        if(isAboutMenu)
        {
            aboutMenu.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Debug.Log("The game has exited");
        Application.Quit();
    }

    public void GoBack()
    {
        if (isControlMenu)
        {
            isControlMenu = false;
            controlsMenu.SetActive(false);
            mainMenu.SetActive(true);

        }
        else if (isAboutMenu)
        {
            isAboutMenu = false;
            aboutMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
    
}
