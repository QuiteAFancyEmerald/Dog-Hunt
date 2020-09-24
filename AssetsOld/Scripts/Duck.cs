using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{

    public Rigidbody2D rb;
    Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetTrigger("destroy");

        void DestroyObjectDelayed()
        {
            // Kills the game object in 5 seconds after loading the object
            Destroy(gameObject, 7);
        }


    }
   
}
