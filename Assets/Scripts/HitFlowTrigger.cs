using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFlowTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("HitGrass RestartObstacle");
        gameManager.RestartObstacle();

    }

}
