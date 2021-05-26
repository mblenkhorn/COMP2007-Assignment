using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //these are the main menu panels
    public GameObject controlsMenu;
    public GameObject aboutMenu;
    public GameObject mainMenu;

    //boolean to check which menu is onscreen
    public bool isControlMenu;
    public bool isAboutMenu;
    public bool isMainMenu;

    public void Start()
    {
        isMainMenu = true; //the main menu is onscreen 
    }



    public void StartGame()
    {
        AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound); //plays sound
        SceneManager.LoadScene("StreetScene"); //loads this level
    }

    public void OpenControlsMenu()
    {
        if(isMainMenu || isAboutMenu) //if main menu is onscreen or about menu is onscreen
        {
            //set ismainmenu and isaboutmenu to false
            isMainMenu = false;
            isAboutMenu = false;
            //set iscontrolmenu to true so that the controls menu is onscreen
            isControlMenu = true;
            AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound); //plays sound
        }

        if (isControlMenu) //if iscontrolmenu is true
        {
            controlsMenu.SetActive(true); //enables visbility of panel
            mainMenu.SetActive(false); //disables visibility of panel
            AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound); //plays sound
        }

    }

    public void OpenAboutMenu()
    {
        if (isMainMenu || isControlMenu) //if main menu or controls menu is onscreen
        {
            //set ismainmenu and iscontrolmenu to false
            isMainMenu = false;
            isControlMenu = false;
            //set isaboutmenu to true so that the about menu is onscreen
            isAboutMenu = true;
            AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound); //plays sound
        } 

        if(isAboutMenu) //if isaboutmenu is true
        {
            aboutMenu.SetActive(true);
            mainMenu.SetActive(false);
            AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound); //plays sound
        } 
    }

    public void ExitGame()
    {
        AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound);  //plays sound
        Debug.Log("The game has exited"); //print this message to the console
        Application.Quit(); //quit the game 
    }

    public void GoBack()
    {
        if (isControlMenu)
        {
            isControlMenu = false;
            controlsMenu.SetActive(false);
            mainMenu.SetActive(true);
            isMainMenu = true;
            AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound); //plays sound

        }
        else if (isAboutMenu)
        {
            isAboutMenu = false;
            aboutMenu.SetActive(false);
            mainMenu.SetActive(true);
            isMainMenu = true;
            AudioManager.instance.PlaySound(AudioManager.instance.confirmSelectionSound); //plays sound
        }
    }
    
}
