using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowEndTrigger3 : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {

        gameManager.TriggerHitFlow3();


    }
}
