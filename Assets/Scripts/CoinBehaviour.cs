using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Assets.Scripts;

public class CoinBehaviour : MonoBehaviour {

    GameManager GMS;
    private float rotateSpeed = 10f;

    void Awake() {

        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
        GMS.cur_coins++;

    }

	
	void Update () {

        transform.Rotate(Vector3.left * rotateSpeed);

	}

    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GMS.cur_coins--;
            GMS.UpdateUI();
        }
    }
}
