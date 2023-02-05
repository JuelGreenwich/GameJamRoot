using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] 
    private void Update()
    {
        time =+ Time.deltaTime;

        if (time >= 10)
        {
            transform.position = transform.position + (Vector3.up * 0.5f * time);
            time = 0;
            
        }
    }
}
