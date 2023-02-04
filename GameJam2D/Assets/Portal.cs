using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    GameObject player;
    [SerializeField] Transform teleportStart;
    [SerializeField] Transform teleportEnd;
    public GameObject game;
    public TheGameManager gameManagerScript;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameManagerScript = GameObject.Find("TheGameManager").GetComponent<TheGameManager>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && gameManagerScript.hasTeleported == false)
        {
            player.transform.position = Vector2.Lerp(teleportStart.position, teleportEnd.position, 1f);
            gameManagerScript.hasTeleported = true;
            Invoke("reactivateTP", 2f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    void reactivateTP()
    {
        gameManagerScript.hasTeleported = false;
    }
}
