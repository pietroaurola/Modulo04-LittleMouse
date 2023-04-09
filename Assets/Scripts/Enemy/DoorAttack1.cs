using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorAttack1 : MonoBehaviour
{
    private bool Timer = true;
    public float StartingTime = 5f;

    public CharacterController controller;

    [SerializeField] private Animator StartTransition;
    public static bool IsTransition = false;
    public GameObject Transition;
    [SerializeField] private AudioSource ScaryDoor;

    // Update is called once per frame
    void Update()
    {
        if (Timer == false)
        {
            Debug.Log("cosa è questo");

            StartingTime -= Time.deltaTime;

            if (StartingTime <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            IsTransition = true;
            Transition.SetActive(true);
            StartTransition.Play("StartTransition");
            ScaryDoor.Play();

            controller.enabled = false;
            Timer = false;
        }
    }
}
