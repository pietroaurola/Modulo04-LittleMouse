using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StudioLevel()
    {
        SceneManager.LoadScene("StudioLevel");
    }

    public void Esc()
    {
        Application.Quit();
    }
}
