using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public Transform PlayerTransform;
    public GameObject Object1;
  
    //public bool Box = false;

    //test
    //Rigidbody Rb;
    public float Thrust = 0f;

    //TEST
    public bool rotation = true;

    //void Update()
    //{
    //    if (Input.GetButtonDown("Fire1") && Box == true)
    //    {
    //        Debug.Log("Sei Mio");
    //        Object.transform.SetParent(PlayerTransform);  

    //        rotation = false;
    //    }
    //    if (Input.GetButtonUp("Fire1"))
    //    {
    //        PlayerTransform.DetachChildren();  
    //        Box = false;
    //        rotation = true;
    //    }
    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Box"))
    //    {
    //        Box = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Box"))
    //    {
    //        Debug.Log("Tornero");
    //        Box = false;
    //    }
    //}

    public GameObject Object2;
    public bool Box2 = false;
    public bool Box1 = false;

    [SerializeField] private Animator PlayerArms;

    //Test
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Sei Mio");
            if(Box1 == true)
            {
                Object1.transform.SetParent(PlayerTransform);
            }

            if (Box2 == true)
            {
                Object2.transform.SetParent(PlayerTransform);
            }
            rotation = false;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            PlayerTransform.DetachChildren();
            Box1 = false;
            rotation = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ci sono");

        if (other.CompareTag("Box"))
        {
            Box1 = true;
            PlayerArms.Play("PlayerArmsUp");
        }

        if (other.CompareTag("Box2"))
        {
            Box2 = true;
            PlayerArms.Play("PlayerArmsUp");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Debug.Log("Tornero");
            Box1 = false;
            PlayerArms.Play("PlayerArmsDown");
        }

        if (other.CompareTag("Box2"))
        {
            Debug.Log("Tornero");
            Box2 = false;
            PlayerArms.Play("PlayerArmsDown");
        }
    }

}

