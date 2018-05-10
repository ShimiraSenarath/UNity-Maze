using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger11 : MonoBehaviour
{

    public GameManager gameManager11;

    void OnTriggerEnter(Collider other)
    {

        gameManager11.TriggerHit11();

    }
}