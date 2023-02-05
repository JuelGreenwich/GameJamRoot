using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootObstacle : MonoBehaviour
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
        if(gameManagerScript.buttonRootsPressed)
        {
            gameObject.transform.position += new Vector3(0, -0.01f, 0);
        }
    }
}
