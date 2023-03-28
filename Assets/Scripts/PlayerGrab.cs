using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public Transform PlayerTransform;
    public GameObject Object;
    public bool Box = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Box == true)
        {
            Debug.Log("preso");
            Object.transform.SetParent(PlayerTransform);
        }
        if(Input.GetButtonUp("Fire1"))
        {
            PlayerTransform.DetachChildren();
            Box = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            Box = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            Box = false;
        }
    }
}
