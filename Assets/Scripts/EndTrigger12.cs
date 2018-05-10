using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger12 : MonoBehaviour {


    public GameManager gameManager12;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Level Won12*****************");
        gameManager12.TriggerHit12();

    }

}
