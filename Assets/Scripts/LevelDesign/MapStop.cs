using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapStop : MonoBehaviour
{
    public Behaviour WatchOut;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WatchOut.enabled = false;
        }
    }
}
