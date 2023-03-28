using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;

    public float CurrentSpeed;
    public float SprintBoost = 0;
    public float WalkSpeed = 0;

    public bool Sprint = false;

    public float TurnSmootTime = 0f;
    float TurnSmoothVelocity;

    public Transform cam;

    public float forceMagnitude;



    public GameObject Object;
    public Transform PlayerTransform;
    public bool Box = false;


    
    public bool Jump = false; //MI SERVE IL TRU E FALSE PER PROCCARE LA ROTAZIONE DEL PG DURANTE IL SALTO
    private Vector3 playerVelocity;
    public float jumpHeight = 10f;
    public float gravityValue = -9.81f;
    
    public void Update()
    {
        CameraMove();
        Run();
        
        if(Input.GetButtonDown("Fire1") && Box == true)
        {
            Object.transform.SetParent(PlayerTransform); //RICORDATI DI FARE IL LOCK DELLA ROTAZIONE DEL PLAYER QUANDO PRENDE LA BOX
            
        }
        if (Input.GetButtonUp("Fire1") )
        {
            PlayerTransform.DetachChildren();
            Box = false;
        }


        //if (Input.GetButtonDown("Fire2"))
        //{
        //    Debug.Log("ssALTA");
        //    GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
        //}

        if (Input.GetButtonDown("Jump"))
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            Debug.Log("ssALTA");
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
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
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref TurnSmoothVelocity, TurnSmootTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            //movimento
            controller.Move(direction * CurrentSpeed * Time.deltaTime);
        }
    }
    private void Run()
    {
        if(Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Fast");
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
   

    //trascinare oggetti
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            Box = true;
        }
    }



}
