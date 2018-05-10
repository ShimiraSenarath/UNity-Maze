using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWallTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("HitGrass");
        gameManager.RestartWall();

    }
}
