using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [Header("Gravity")]
    public float gravity = -7.5f;
    Vector3 FallVelocity;

    [Header("Test")]
    public GameObject box;

    //Rigidbody rb;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    // Update is called once per frame
    void Update()
    {
        Gravity();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        rb.constraints = RigidbodyConstraints.FreezePositionX;
    //    }
    //}

    private void Gravity()
    {
        FallVelocity.y += gravity * Time.deltaTime;
    }
}
