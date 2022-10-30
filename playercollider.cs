using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercollider : MonoBehaviour
{
    public playermovement movement;
    



       
        void OnCollisionEnter(Collision collisioninfo)
        {
            if (collisioninfo.collider.tag == "Obstacle")
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                

            }
        }
    

}