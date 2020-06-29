using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameend : MonoBehaviour
{
    public GameObject spawner;

    public GameObject arm;

    public GameObject panel;

    public GameObject border;

    public GameObject duckend;

    public AudioSource end;

    public GameObject sound;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawner.SetActive(false);

        arm.GetComponent<weapon>().enabled = false;

        panel.transform.GetChild(0).gameObject.SetActive(true);

        duckend.SetActive(true);

        end.enabled = true;

        sound.GetComponent<AudioSource>().enabled = false;
    }
}
