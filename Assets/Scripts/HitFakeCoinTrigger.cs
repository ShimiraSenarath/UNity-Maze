using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFakeCoinTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("HitGrass");
        gameManager.RestartCoin();

    }
}
