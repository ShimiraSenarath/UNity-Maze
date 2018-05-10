using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public float mouseSence;
    public Transform playerBody;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        RotateCamera();

    }
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    void RotateCamera()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mouseSence;
        float rotAmountY = mouseY * mouseSence;

        Vector3 targetRotCam = transform.rotation.eulerAngles;
        Vector3 targetRotBody = playerBody.rotation.eulerAngles;

        targetRotCam.x -= rotAmountY;
        //targetRotCam.x += rotAmountY;
        targetRotBody.y += rotAmountX;
        targetRotCam.z = 0;

        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);

    }
}
