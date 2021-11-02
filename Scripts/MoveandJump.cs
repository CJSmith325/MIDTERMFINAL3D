using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveandJump : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Transform bounceCheck;
    public float bounceDistance = 2f;
    public LayerMask bounceMask;

    Vector3 velocity;
    bool isGrounded;
    bool isBouncing;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isBouncing = Physics.CheckSphere(bounceCheck.position, bounceDistance, bounceMask);


        if (isBouncing && velocity.y < 0)
        {
            velocity.y = 4.5f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
