using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthAnimation : MonoBehaviour
{
    public Behaviour WatchOut;

    private Animator MouthPoint;

    MouthAnimation()
    {
        if (WatchOut.enabled == true)
        {
            MouthPoint.Play("Mouth");
        }
    }
}
