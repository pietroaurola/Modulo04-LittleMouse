using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretBotton : MonoBehaviour
{
    public void PianoTerra()
    {
        SceneManager.LoadScene(2);
    }

    public void Seminterrrato()
    {
        SceneManager.LoadScene(1);
    }
}
