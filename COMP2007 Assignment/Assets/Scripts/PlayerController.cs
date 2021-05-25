using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; //determines how fast the player moves
    public Rigidbody rb;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask whatIsGround;
    public bool isGrounded;

    Vector3 velocity;


    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, whatIsGround);
    }



    private void Update()
    {
        Move(); //runs this function

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

    }

   


    public void Move()
    {
        float x = Input.GetAxis("Horizontal"); //gets the horizontal inputs (left and right)
        float z = Input.GetAxis("Vertical"); //gets the vertical inputs (up and down)

        Vector3 movement = new Vector3(x, 0f, z).normalized * moveSpeed * Time.deltaTime; //allows the Player to move with the set speed and make it run frame independent
        transform.Translate(movement, Space.Self); //allows the Player to move in that direction
    }

    public void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
    }






}
