using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{

    private int Health = 1;
    public AudioClip Boom;


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.scoreManager.RaiseScore(5);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Boom);
        Death();
    }

    private void Death()
    {
        Health -= 1;

        if (Health == 0) Destroy(gameObject);



    }
}
