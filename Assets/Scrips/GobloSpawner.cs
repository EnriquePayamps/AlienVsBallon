using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobloSpawner : MonoBehaviour
{
    float timer;
    float timeer;
    float timeeer;
    public GameObject globoPrifab;
    public GameObject globoEspecial;
    public GameObject globoTres;
    private int Health = 1;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;         
        timeer += Time.deltaTime;
        timeeer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0;
            float x = Random.Range(-60f, 40f);
            Vector3 position = new Vector3(x, -35, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(globoPrifab, position, rotation);
        }
        if (timeer >= 3f)
        {
            timeer = 0;
            float x = Random.Range(-60f, 40f);
            Vector3 position = new Vector3(x, -35, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(globoEspecial, position, rotation);
        }
        if (timeeer >= 2f)
        {
            timeeer = 0;
            float x = Random.Range(-60f, 40f);
            Vector3 position = new Vector3(x, -35, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(globoTres, position, rotation);
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
