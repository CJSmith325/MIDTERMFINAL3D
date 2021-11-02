using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        movement = movement.normalized * speed * Time.deltaTime;

      //  Vector3 newPosition = transform.position;
      //  newPosition = newPosition + movement;

        //transform.position = newPosition;
        controller.Move(movement);
    }
}
