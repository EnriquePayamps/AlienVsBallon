using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{

    private int Health = 1;
    public AudioClip Boom;
    public int puntos; 


    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.scoreManager.RaiseScore(puntos);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Boom);
        gameObject.SetActive(false);
        Death();
    }

    private void Death()
    {
        Health -= 1;

        if (Health == 0) Destroy(gameObject);

    }
}
