using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSettings : MonoBehaviour
{
    public Slider slider;
    public Light SceneLight;

    // Update is called once per frame
    void Update()
    {
        SceneLight.intensity = slider.value;
    }
}
