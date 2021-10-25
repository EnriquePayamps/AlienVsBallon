using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public Renderer Background;
    // Start is called before the first frame update
    void Start()
    {
        //HealthSystem healthSystem = new HealthSystem(100);

        //Debug.Log("Health " + healthSystem.GetHealth());
        //healthSystem.Damage(10);
        //Debug.Log("Health " + healthSystem.GetHealth());

        //healthSystem.Heal(10);
        //Debug.Log("Health " + healthSystem.GetHealth());



    }

    // Update is called once per frame
    void Update()
    {
        Background.material.mainTextureOffset = Background.material.mainTextureOffset + new Vector2(.05f, 0) * Time.deltaTime;
    }
}
