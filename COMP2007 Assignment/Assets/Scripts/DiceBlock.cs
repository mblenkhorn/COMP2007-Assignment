using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceBlock : MonoBehaviour
{
    public float rotateSpeed; //how fast the object will rotatw

    public int score = 0; //score of the diceblock

    public int maxBlocks = 5; //how much of each diceblock variant is in the area


    public ScoreManager manager; //a reference to the scoremanager


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime); //rotates the object by the movespeed (frame-independent)
    }

    
  
    private void OnTriggerEnter(Collider other)
    {
        manager.AddScore(1); //calls the AddScore function with 1 passed in as an argument
        gameObject.SetActive(false); //disables visibility of the object 
    }
}
