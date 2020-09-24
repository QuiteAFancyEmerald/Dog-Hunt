using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject obstacle;

    void start () {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
