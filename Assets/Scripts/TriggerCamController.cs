using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamController : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
    }
}
