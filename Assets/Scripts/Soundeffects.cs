using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffects : MonoBehaviour
{

    public AudioSource shot;
    public AudioSource walk;
    public AudioSource jump;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shot.enabled = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            shot.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            walk.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            walk.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            walk.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            walk.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            jump.enabled = false;
        }

    }
}
