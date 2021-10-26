using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobloSpawner : MonoBehaviour
{
    float timer;
    public GameObject globoPrifab;
    private int Health = 1;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            timer = 0;
            float x = Random.Range(-4.949311f, 4f);
            Vector3 position = new Vector3(x, -6, 0);
            Quaternion rotation = new Quaternion();

            Instantiate(globoPrifab, position, rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.scoreManager.RaiseScore(5);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Death();
    }

    private void Death()
    {
        Health -= 1;

        if (Health == 0) Destroy(gameObject);



    }
}
