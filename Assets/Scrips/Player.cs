using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Bullet;
    private float LastShoot;
    Vector2 input;
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    public AudioClip Boom;
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
    }

    private void FixedUpdate()
    {
        rigidbody2d.velocity = input * Speed * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.45f)
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
         

        if (Health == 0)   animator.SetInteger("IsDeath", Health); Destroy(gameObject, 0.5f);
        
        

    }

}
