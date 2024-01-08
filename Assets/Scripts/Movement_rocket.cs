using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_rocket : MonoBehaviour
{
    
    public float speed = 0;


    // Update is called once per frame
    void Update()
    {
        // Movement of the rocket with ZQSD and rotation of the rocket when left or right
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector2 movement = new Vector2(moveX, moveY);
        
        movement.Normalize();
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
        
    }
}
