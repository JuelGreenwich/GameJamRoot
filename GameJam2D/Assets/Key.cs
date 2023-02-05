using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]private PlayerInventory inventory;

    private void Start()
    {
        inventory = GameObject.Find("TheGameManager").GetComponent<PlayerInventory>();
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           //col.gameObject.
           inventory.hasKey = true;
            Destroy(this.gameObject);
        }
    }
}
