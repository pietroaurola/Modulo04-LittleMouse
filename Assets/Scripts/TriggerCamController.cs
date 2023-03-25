using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamController : MonoBehaviour
{
    //public GameObject OldCamera;
    //public GameObject NewCamera;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("Player"))
    //    {
    //        OldCamera.SetActive(false);
    //        NewCamera.SetActive(true);
    //    }
    //}

    public Transform cam;

    public GameObject NewCameraPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            cam.transform.position = NewCameraPoint.transform.position;
        }
    }
}

