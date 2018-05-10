using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFireTrriger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        Debug.Log("HitFire");
        gameManager.RestartFier();

    }

}
