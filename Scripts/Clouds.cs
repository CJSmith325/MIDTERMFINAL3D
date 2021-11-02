using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
   public float speed = 1.5f;
    
    // Update is called once per frame
    void Update()
    {   
        //store current position of the object to change it.
        Vector3 temp = this.transform.position;

        //temp.x += speed; would work as well. Match time with frame rate Time.deltaTime
        temp.x = temp.x + speed * Time.deltaTime;


        //we assign temp as the new position of the object.
        //We're teleporting the object in very small amount quickly.
        this.transform.position = temp;

    }
}
