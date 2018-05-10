using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movw : MonoBehaviour
{

    public CharacterController charCTRL;
    public float walkSpeed = 1.0f;
    public float runSpeed = 5.0f;
    private Rigidbody rb;
    public GameObject Grass;

    public Animator anim;
  //  public Animator G5Ani;

    //public LayerMask groundLayers;

    private float verticalVelocity;
    private float gravity = 14.0f;
    public float jumpForce = 10.0f;
    public CharacterController controller;

    

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
       // G5Ani = GetComponent<Animator>();
        

    }

    private void Awake()
    {

        charCTRL = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        
        MovePlayre();
        RunPlayre();
        JumpPlayer();
       // HitGrass();
        

    }

 /*   public void HitGrass()
    {
       
                Debug.Log("Hit Me_Player");
                G5Ani.Play("walk");
          

    }*/

    


    void MovePlayre()
    {
        anim = GetComponent<Animator>();

        float horiZ = Input.GetAxis("Horizontal");
        float verT = Input.GetAxis("Vertical");

        Vector3 moveDirSide = transform.right * horiZ * walkSpeed;
        Vector3 forwerd = transform.forward * verT * walkSpeed;

        charCTRL.SimpleMove(moveDirSide);
        charCTRL.SimpleMove(forwerd);

        // Vector3 up = transform.TransformDirection(Vector3.up);
        //rigidbody.AddForce(up * jumpForce);
      /*  if (Input.GetKey(KeyCode.CapsLock))
        {
            anim.Play("walk");
        }
      */  

    }

    void RunPlayre() {

        if (Input.GetKey(KeyCode.LeftShift))
        {

            float horiZ = Input.GetAxis("Horizontal");
            float verT = Input.GetAxis("Vertical");

            Vector3 moveDirSide = transform.right * horiZ * runSpeed;
            Vector3 forwerd = transform.forward * verT * runSpeed;

            charCTRL.SimpleMove(moveDirSide);
            charCTRL.SimpleMove(forwerd);

        }
    
    }

    void JumpPlayer()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;

            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);

    }
    
}
