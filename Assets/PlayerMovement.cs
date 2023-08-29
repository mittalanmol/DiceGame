using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 2000f;
    public float sidewayforce = 500f;

    //We marked this as "Fixed"Update because we are 
    //using it to mess with physics
    // Update is called once per frame
    void FixedUpdate()
    {
        //Adding a Forward Force
        rb.AddForce(0, 0, forwardforce*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayforce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
