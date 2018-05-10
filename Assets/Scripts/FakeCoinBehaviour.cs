using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeCoinBehaviour : MonoBehaviour {

    GameManager GMS;
    private float rotateSpeed = 10f;
    public GameManager gameManager;

  /*  void Awake()
    {

        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
        GMS.cur_coins++;

    }*/


    void Update()
    {

        transform.Rotate(Vector3.right * rotateSpeed);

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            gameManager.RestartWall();
        }
    }

}
