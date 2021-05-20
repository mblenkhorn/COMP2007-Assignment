using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceBlock : MonoBehaviour
{
    public float rotateSpeed;

    public int score;

    public ScoreManager manager;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
            manager.AddScore(score);
            Destroy(gameObject); 
    }
}
