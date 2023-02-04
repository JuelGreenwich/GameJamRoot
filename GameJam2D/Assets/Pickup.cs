using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    
    private ScoreManager _scoreManager;
    private void Start()
    {
        _scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           // _scoreManager.AddScore();
            
        }
        
    }
}
