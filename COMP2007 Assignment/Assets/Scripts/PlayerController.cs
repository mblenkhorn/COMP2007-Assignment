using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; //determines how fast the player moves
    public Rigidbody rb; //a reference to the rigidbody component
    public float jumpHeight; //how high the player jumps

    public Transform groundCheck; //checks for ground
    public float groundDistance = 0.4f; //distance of ground check
    public LayerMask whatIsGround; //gets the ground layer
    public bool isGrounded; //checks if the player is grounded

    Vector3 velocity; //gets the velocity of the player if the player steps off a platform

    //public Animator anim;


    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, whatIsGround); //checks whether the player is grounded or not
    }



    private void Update()
    {
        Move(); //runs this function

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            Debug.Log("Has Jumped");
        }

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //how far down the player will go after stepping off a platform
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
        rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z); //allows the player to jump
    }






}
