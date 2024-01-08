using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        float randomX = Random.Range(-5.5f, 5.5f);
        
        transform.position = new Vector3(randomX, 5.5f, 0);
        
        speed = Random.Range(1.0f, 3.0f);
        
        float randomRotation = Random.Range(-90, 45);
        
        transform.Rotate(0, 0, randomRotation);
        
        float randomScale = Random.Range(0.04f, 0.1f);
        
        transform.localScale = new Vector3(randomScale, randomScale, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = speed * Time.deltaTime;
        float moveY = -speed * Time.deltaTime;
        
        transform.Translate(new Vector3(moveX, moveY, 0));
    }
    
    // When the asteroid is out of the screen, destroy it
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("Asteroid destroyed");
    }
    
    // When the asteroid collides with another asteroid, destroy it
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroid(Clone)"))
        {
            Destroy(gameObject);
            Debug.Log("Asteroid destroyed MQLSKDMQSLKD MQLSKDMLQSK DMOQSKDMLQSKJD QKDSLQKSJD LQKSDJ");
        }
    }
}
