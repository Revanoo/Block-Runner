using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{

    playerMovement1 playerMovement;

    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<playerMovement1>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Update()
    {

    }
}