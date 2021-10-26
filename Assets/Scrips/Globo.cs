using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{

    private int Health = 1;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject scripter = GameObject.Find("Scripter");
        scripter.GetComponent<ScoreManager>().RaiseScore(1);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.scoreManager.RaiseScore(5);
        Death();
    }

    private void Death()
    {
        Health -= 1;

        if (Health == 0) Destroy(gameObject);



    }
}
