using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovevs02 : MonoBehaviour
{
    [SerializeField] private Camera characterCamera;
    [SerializeField] private float speedH = 2.0f;
    [SerializeField] private float speedV = 2.0f;
    [SerializeField] private float walkingSpeed = 2f;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private PlayerTurn playerTurn;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    
    [SerializeField] private float pitchClamp = 90;

void Start()
{
    Cursor.visible = false;
}

void Update()
{
    bool IsPlayerTurn = playerTurn.IsPlayerTurn();
    if (IsPlayerTurn)
    {
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * walkingSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
            }
        }
        characterBody.useGravity = true;
        
        if (Input.GetAxis("Vertical") != 0)
            {
               transform.Translate(transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
            }
        ReedRotationInput();

        if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor())
        {
            Jump();
        }
    }
    else
    {
        characterBody.velocity = Vector3.zero;
        characterBody.useGravity = false;
    }
}
    private void ReedRotationInput()
    {
         yaw += speedH * Input.GetAxis("Mouse X");
         pitch -= speedV * Input.GetAxis("Mouse Y");
         pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);
         
         characterCamera.transform.localEulerAngles = new Vector3(pitch, 0f,0f);
         transform.eulerAngles = new Vector3(0f,yaw,0f);
         
    }
    private void Jump()
    {
        //characterBody.velocity = Vector3.up * 10f;
        characterBody.AddForce(Vector3.up * 475f);
    }

    private bool IsTouchingFloor()
    {
        RaycastHit hit;
        bool result =  Physics.SphereCast(transform.position, 0.25f, -transform.up, out hit, 1f);
        return result;
    }
}