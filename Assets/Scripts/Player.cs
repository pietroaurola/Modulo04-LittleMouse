using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Character Controller")]
    public CharacterController controller;

    [Header("Camera")]
    public Transform cam;

    [Header("Player Rotation")]
    public float TurnSmootTime = 0f;
    float TurnSmoothVelocity;

    [Header("Sprint")]
    public float CurrentSpeed;
    public float SprintBoost = 0;
    public float WalkSpeed = 0;
    public bool Sprint = false;

    [Header("Gravity")]
    public float gravity = -7.5f;
    Vector3 FallVelocity;

    [Header("Jump")]
    public float JumpForce;

    [Header("Ground Detection")]
    public Transform GroundCheck;
    public float GroundRadius;
    public LayerMask WhatIsGround;
    public bool isGrouded;

    [Header("Test")]
    public PlayerGrab pg;

    //public bool Jump = false; //MI SERVE IL TRU E FALSE PER PROCCARE LA ROTAZIONE DEL PG DURANTE IL SALTO
    //private Vector3 playerVelocity;
    //public float jumpHeight = 10f;
    //public float gravityValue = -9.81f;


    public void Update()
    {
        CameraMove();
        Run();
        Gravity();
        Jump();
    }

    private void CameraMove()
    {
        //input axis
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        //camera direction
        Vector3 camFoward = cam.forward;
        Vector3 camRight = cam.right;

        camFoward.y = 0;
        camRight.y = 0;

        //creating reelate cam direction
        Vector3 forwardRelative = vertical * camFoward;
        Vector3 rightRelative = horizontal * camRight;

        Vector3 moveDir = forwardRelative + rightRelative;

        //vettore di movimento
        Vector3 direction = new Vector3(moveDir.x, 0f, moveDir.z).normalized;

        //rotazion player
        if(direction.magnitude >= 0.1f)
        {
            if(pg.rotation == true)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref TurnSmoothVelocity, TurnSmootTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            }
           
            //movimento
            controller.Move(direction * CurrentSpeed * Time.deltaTime);
        }
    }
    private void Run()
    {
        if(Input.GetButtonDown("Fire3"))
        {
            Debug.Log("I'm Speed");
            Sprint = true;
        }
        else
        {
            if(Sprint == true)
            {
                CurrentSpeed = SprintBoost;
            }
        }

        if(Input.GetButtonUp("Fire3"))
        {
            Sprint = false;
        }
        else
        {
            if(Sprint == false)
            {
                CurrentSpeed = WalkSpeed;
            }
        }
    }
    private void Gravity()
    {
        FallVelocity.y += gravity * Time.deltaTime;
        controller.Move(FallVelocity * Time.deltaTime);
    }
    private void Jump()
    {
        //GroundCheck
        isGrouded = Physics.CheckSphere(GroundCheck.position, GroundRadius, (int)WhatIsGround);

        //Jump
        if (Input.GetButtonDown("Fire2") && isGrouded == true)
        {
            Debug.Log("I Belive I Can Fly");
            FallVelocity.y = JumpForce;
        }
    }
}
