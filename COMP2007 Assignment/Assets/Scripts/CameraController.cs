using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 1f; //how fast the Camera rotates
    public Transform target; //this is for the target Camera object
    public Transform player; //this is for the Player

    float mouseX; //mouse movement on the x-axis
    float mouseY; //mouse movement on the y-axis

    private void Start()
    {
        //Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
    }


    private void LateUpdate()
    {
        CameraControl();
    }


    public void CameraControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed; //controls camera from left to right
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed; //controls camera up and down

        mouseY = Mathf.Clamp(mouseY, -35, 60); //clamps the camera movement to avoid overdoing the rotations

        transform.LookAt(target); //the camera will always look at the target

        //these allow both the camera, the target and the player to rotate accordingly 
        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);


       
    }
}
