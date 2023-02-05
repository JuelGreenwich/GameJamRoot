using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //public TheGameManager gameManagerScript;
    public bool pressed;

    // Start is called before the first frame update
    void Start()
    {
        //gameManagerScript = GameObject.Find("TheGameManager").GetComponent<TheGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.transform.localScale -= new Vector3(0, 0.5f, 0);
            gameObject.transform.position -= new Vector3(0, 0.25f, 0);
            pressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressed = false;
        gameObject.transform.localScale += new Vector3(0, 0.5f, 0);
        gameObject.transform.position += new Vector3(0, 0.25f, 0);
    }
}
