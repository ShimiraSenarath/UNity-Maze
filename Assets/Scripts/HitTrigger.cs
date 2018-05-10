using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour {

   // public Player_Movw Hit;
    public Animator G5Ani;

  /*  void OnTriggerEnter()
    {
        Debug.Log("Hit MeTrigger");
        Hit.HitGrass();
    }
    */
	// Use this for initialization
	void Start () {

        G5Ani = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit MeTrigger");
            G5Ani.Play("walk");

        }

    }
}
