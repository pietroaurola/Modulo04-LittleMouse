using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float Speed = 0;

    public float TurnSmootTime = 0f;
    float TurnSmoothVelocity;
    

    public Transform cam;


    private void Update()
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

        Vector3 direction = new Vector3(moveDir.x, 0f, moveDir.z).normalized;


        //rotazion player
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref TurnSmoothVelocity, TurnSmootTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(direction * Speed * Time.deltaTime);
        }
    }
}
