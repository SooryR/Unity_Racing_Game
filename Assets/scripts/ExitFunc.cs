using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitFunc : MonoBehaviour
{
    void Start()
    {

    }

    void Update() {
        
    }

    public void runExit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
