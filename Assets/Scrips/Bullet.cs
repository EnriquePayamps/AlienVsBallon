using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
    
{
    public float Speed;
    private Rigidbody2D rigidbody2d;
    private Vector2 Direction;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rigidbody2d.velocity = Vector2.left * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
