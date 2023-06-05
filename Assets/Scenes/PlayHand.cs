using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHand : MonoBehaviour
{
    public Behaviour HandFollow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HandFollow.enabled = true;
        }
    }
}
