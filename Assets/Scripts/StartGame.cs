using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
    
}