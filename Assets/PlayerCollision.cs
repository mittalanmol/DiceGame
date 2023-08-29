using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //A reference to player movement script
    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag=="Obstacle")
        {
            movement.enabled = false; // can reference also using GetComponent<PlayerMovement>().enabled = false

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
