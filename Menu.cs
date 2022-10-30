using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void Nextlevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }


    public void Nextlevel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }


    public void tryagain2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
