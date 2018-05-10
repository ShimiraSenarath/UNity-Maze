using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGrassTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("HitGrass");
        gameManager.GrassHit();

    }
}
