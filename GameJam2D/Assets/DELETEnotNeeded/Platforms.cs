using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public TheGameManager gameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("TheGameManager").GetComponent<TheGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.buttonPlatformsPressed)
        {
            gameObject.SetActive(false);
        }
        else
        {
            print("yes");
            gameObject.SetActive(true);
        }
    }
}
