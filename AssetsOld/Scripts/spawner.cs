using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour{

    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimebtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if (timeBtwSpawn <= 0) 
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimebtwSpawn;
            if (startTimebtwSpawn >  minTime) {
                startTimebtwSpawn -= decreaseTime;
            }
            
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
