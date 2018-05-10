using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger6 : MonoBehaviour {

    public GameManager gameManager6;

    void OnTriggerEnter(Collider other)
    {

        gameManager6.TriggerHit6();

    }
}
