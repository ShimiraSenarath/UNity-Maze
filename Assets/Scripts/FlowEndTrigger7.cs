using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowEndTrigger7 : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {

        gameManager.TriggerHitFlow7();


    }
}
