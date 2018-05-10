using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Player_Movw movement;
    public GameManager Restart;
    public GameManager RestartWall;

    void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle")
        {

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            //Restart.EndGame();
        }
    
    }

}
