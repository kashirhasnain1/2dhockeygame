using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment2 : MonoBehaviour
{
    public int speed = 3;
    public Rigidbody2D rigidbody1;
    
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();
            
    }

    
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        Debug.Log("mov");
        rigidbody1.velocity = new Vector3(mov * speed, rigidbody1.velocity.y, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody1.velocity = new Vector3(rigidbody1.velocity.y, speed);
        }
    }
}
