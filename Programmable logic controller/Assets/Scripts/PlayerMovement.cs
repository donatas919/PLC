using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public Transform orientation;
    
    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;
    
    private void Update()
    {
        MyInput();
        //SpeedControl();
    }
    
    private void FixedUpdate()
    {
        MovePlayer();
    }
    
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    
    private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        transform.position += transform.forward * moveSpeed * verticalInput * Time.deltaTime;
        transform.position += transform.right * moveSpeed * horizontalInput * Time.deltaTime;
    }
}
