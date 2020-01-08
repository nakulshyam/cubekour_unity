using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstacle Hit, May Day May Day!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
