using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject asteroidPrefab;
    
    // Update is called once per frame
    void Update()
    {
        // Spawn a prefab every 0.75 seconds
        if (Time.frameCount % 60 == 0)
        {
            // Instantiate the prefab with the tag "Asteroid"
            GameObject asteroid = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
        }
    }
}
