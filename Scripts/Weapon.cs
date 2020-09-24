using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float minRotation = -28.225f;

    public float maxRotation = 12.52f;

    public float offset;

    public GameObject projectile;

    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private Shake shake;
    private object Wall;

    public AudioSource gunShot;

    void Start(){
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        rotZ = Mathf.Clamp(rotZ, minRotation, maxRotation);
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0) {
            if (Input.GetMouseButton(0))
            {
                shake.Camshake();
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;


                if (Input.GetMouseButtonUp(0))
                {
                    gunShot.enabled = false;
                }
            }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }

    }
}




