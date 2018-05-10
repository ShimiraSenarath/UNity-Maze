using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWall1Trigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("HitWall");
        gameManager.TriggerHitwall1();

    }
}
