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

		// Rotation of the rocket
		if (movement.x != 0 || movement.y != 0)
        {
         	float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);  
        }

	    // Movement of the rocket        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
        
		// Inertia (Continue the move but slow fast)
	    rb.velocity = movement * speed;
    }
}
