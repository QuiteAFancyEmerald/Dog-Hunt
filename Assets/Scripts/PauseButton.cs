using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){ 
            Debug.Log("QUIT!");
            Application.Quit();
        }
    }
}
