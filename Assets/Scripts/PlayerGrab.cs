using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public Transform PlayerTransform;
    public GameObject Object;
    public bool Box = false;

    //test
    Rigidbody Rb;
    public float Thrust = 0f;

    //TEST
    public bool rotation = true;

   
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Box == true)
        {
            Debug.Log("Sei Mio");
            Object.transform.SetParent(PlayerTransform);  //cambiare in addforce
          
            rotation = false;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            PlayerTransform.DetachChildren();  //togliere
            Box = false;
            rotation = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Box = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Debug.Log("Tornero");
            Box = false;
        }
    }
}
