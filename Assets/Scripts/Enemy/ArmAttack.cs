using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmAttack : MonoBehaviour
{
    [SerializeField] public GameObject Player;
    [SerializeField] public Transform HandEnemyTransform;
    [SerializeField] private AudioSource ScaryArm;

    private bool Attack = true;
    public CharacterController controller;

    private void Update()
    {
        if(Attack == false)
        {
            Player.transform.SetParent(HandEnemyTransform);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Attack = false;
            controller.enabled = false;
            ScaryArm.Play();
        }
    }
}
