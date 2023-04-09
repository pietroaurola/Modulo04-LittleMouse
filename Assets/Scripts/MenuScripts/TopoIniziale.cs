using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopoIniziale : MonoBehaviour
{
    [SerializeField] private Animator EndTransition;

    // Start is called before the first frame update
    void Start()
    {
        EndTransition.Play("EndTransition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
