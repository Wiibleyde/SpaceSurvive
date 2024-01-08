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
            Debug.Log("Spawn a prefab");
            // Instantiate the prefab
            GameObject asteroid = Instantiate(asteroidPrefab);
            
        }
    }
}
