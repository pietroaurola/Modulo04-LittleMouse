using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneLevel : MonoBehaviour
{
    public void StudioLevel()
    {
        SceneManager.LoadScene("StudioLevel");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StudioLevel();
        }
    }

}
