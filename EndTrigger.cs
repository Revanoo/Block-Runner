using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public Gamemanager gamemanager;
    void OnTriggerEnter()
    {
       gamemanager.CompleteLevel();
        
    }
}
