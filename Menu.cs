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

    public void Nextlevel4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void Nextlevel5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }



    public void Nextlevel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }


    public void tryagain2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }

    public void tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
