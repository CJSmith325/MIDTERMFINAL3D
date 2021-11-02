using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump1 : MonoBehaviour
{
    public float jumpforce;
    public Rigidbody reggiebody;
    public float speed = 1.0f;
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        movement = movement.normalized * speed * Time.deltaTime;

        controller.Move(movement);
        if (Input.GetButtonDown("Jump"))
        {
            //Vector3.up = (0, 1, 0);
            Vector3 forceVector = Vector3.up * jumpforce;
            reggiebody.AddForce(forceVector);

            print("Down");

        }
        else if (Input.GetButton("Jump"))
        {
            print("Hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            print("Up");

        }
        

    
        
    }
}
