using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndScene : MonoBehaviour
{
    public void PianoTerra()
    {
        SceneManager.LoadScene(3);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PianoTerra();
        }
    }
}
