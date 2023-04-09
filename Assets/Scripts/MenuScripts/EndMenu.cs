using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuStart");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
