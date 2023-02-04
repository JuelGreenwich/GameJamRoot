using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private CapsuleCollider2D collider;
    [SerializeField]private PlayerInventory playerInventory;
    void Start()
    {
        collider = GetComponent<CapsuleCollider2D>();
        playerInventory = GameObject.Find("GameManager").GetComponent<PlayerInventory>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (playerInventory.hasKey)
            {
                print("Hahahahahaha");
                Destroy(this.gameObject);
            }
        }
    }
}
