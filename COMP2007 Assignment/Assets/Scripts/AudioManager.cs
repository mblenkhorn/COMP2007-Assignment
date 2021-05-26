using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //these are for the sound effects
    public AudioSource collectSound;
    public AudioSource confirmSelectionSound;

    //this is the instance of the audiomanager - can reference it without creating an object
    public static AudioManager instance;

    void Start()
    {
        instance = this; //sets the instance to the gameobject the script is attached to
    }


    public void PlaySound(AudioSource source) //when a sound effect is used as an argument, it will play the sound
    {
        source.Stop(); //stops the sound
        source.Play(); //plays the sound
    }
}
