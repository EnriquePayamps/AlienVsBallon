using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject Bullet;
    private float LastShoot;
    Vector2 input;
    float tiempo;
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    public AudioClip Boom;
    public GameObject GameOver;
    private int Health = 1;

    public float Speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        input.y = Input.GetAxis("Vertical");
        
        if (ScoreManager.scoreManager.score <= 0)
        {
            Death();
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            Time.timeScale = 0;
        }
        if (Input.GetKey(KeyCode.R))
        {
            RestarGame();
            Time.timeScale = 1;
        }
        



    }

    private void FixedUpdate()
    {
        rigidbody2d.velocity = input * Speed * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.C) && Time.time > LastShoot + 0.45f)
        {
            shoot();
            LastShoot = Time.time;
        }

        
    }
    private void shoot()
    {
        GameObject bullet = Instantiate(Bullet, transform.position * 0.84f, Quaternion.identity);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Boom);
        Death();
        
        



    }

    private void Death()
    {
        Health -= 1;

        
        if (Health == 0) 
        
        {
            
            animator.SetInteger("IsDeath", Health);
            //Destroy(gameObject, 0.5f);
            //Time.timeScale = 0;
            GameOver.SetActive(true);
            
            
            



        }
        
            
        

    }
  
        
    public void RestarGame()
    {

        
            SceneManager.LoadScene("SampleScene");
        


    }

}
