using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public bool hasKey;

    [SerializeField] private Image keyImage;

    private void Start()
    {
        //keyImage.enabled = false;
    }

    private void Update()
    {
        /*if (hasKey)
        {
            keyImage.enabled = true;
        }*/
    }
}
