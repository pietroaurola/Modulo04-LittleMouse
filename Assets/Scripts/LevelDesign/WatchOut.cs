using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchOut : MonoBehaviour
{
    public float movingSpeed = 1f;
    [Header ("valore 0.05 per build")]
    public float velocity = 0.1f;

    // Update is called once per frame
    void Update()
    {
        movingSpeed += velocity * (Time.deltaTime);

        Vector3 speed = new Vector3(-movingSpeed, 0, 0);

        transform.position = speed;
    }
}
