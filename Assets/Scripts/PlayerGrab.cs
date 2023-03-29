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

    //private void Start()
    //{
    //    Rb = GetComponent<Rigidbody>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetButtonDown("Fire1") && Box == true)
    //    {
    //        Debug.Log("preso");
    //        //Object.transform.SetParent(PlayerTransform);  //cambiare in addforce
    //        Rb.AddForce(transform.forward * Thrust);
    //    }
    //    if(Input.GetButtonUp("Fire1"))
    //    {
    //        //PlayerTransform.DetachChildren();  //togliere
    //        Box = false;
    //    }
    //}
    //private void ontriggerenter(collider other)
    //{
    //    if(other.comparetag("box"))
    //    {
    //        box = true;
    //    }
    //}
    //private void ontriggerexit(collider other)
    //{
    //    if(other.comparetag("box"))
    //    {
    //        box = false;
    //    }
    //}
    
    private void OnControllerCollliderHit(ControllerColliderHit hit)
    {
        if (Input.GetButtonDown("Fire1") && Box == true)
        {
            Debug.Log("preso");
            //if (Rb != null)
            //{
            //    Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            //    forceDirection.y = 0;
            //    forceDirection.Normalize();

            //    Rb.AddForceAtPosition(forceDirection * Thrust, transform.position, ForceMode.Impulse);
            //}
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Box = false;
        }

        Rigidbody Rb = hit.collider.attachedRigidbody;

        if (Rb != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            Rb.AddForceAtPosition(forceDirection * Thrust, transform.position, ForceMode.Impulse);
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
            Box = false;
        }
    }
}
