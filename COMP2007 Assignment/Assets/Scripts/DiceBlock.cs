using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceBlock : MonoBehaviour
{
    public float rotateSpeed;

    public int score;

    public int maxBlocks = 5;


    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    
    public void Collect()
    {
        AddScore(1);
        gameObject.SetActive(false);
    }

    

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log(score);
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Collect();
    }
}
