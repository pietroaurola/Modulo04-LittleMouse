using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmTrigger : MonoBehaviour
{
    [SerializeField] private Animator arm;
    [SerializeField] private AudioSource ScaryArm;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            arm.Play("Braccio");
            ScaryArm.Play();
        }
    }
}
