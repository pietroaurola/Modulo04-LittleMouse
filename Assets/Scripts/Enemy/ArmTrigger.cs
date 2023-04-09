using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmTrigger : MonoBehaviour
{
    public GameObject Sc;
    [SerializeField] private Animator SecondBr;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Sc.SetActive(false);

            SecondBr.Play("SecondArm");
        }
    }
}
