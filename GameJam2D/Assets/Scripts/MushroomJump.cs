using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomJump : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            var jumpCol = col.gameObject.GetComponent<PlayerMovement>();
            jumpCol.Jump(20);
            Debug.Log("Hello");
        }
    }
}
