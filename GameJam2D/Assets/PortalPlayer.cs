using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPlayer : MonoBehaviour
{
    GameObject player;
    [SerializeField] Transform teleportStart;
    [SerializeField] Transform teleportEnd;
    public bool alreadyTeleported; //MAKE THIS PRIVATE
    
    Collider2D objCollider;
    public Portal portalScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        print(player.transform.position.x);
        portalScript = gameObject.GetComponent<Portal>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger");
        if (collision.tag == "Portal" && alreadyTeleported == false)
        {
            print("Player found!");
            player.transform.position = Vector2.Lerp(teleportStart.position, teleportEnd.position, 1f);

            //reactivateTP();
            //alreadyTeleported = true;

            //objCollider.enabled = false;
            portalScript.enabled = false;

            Invoke("reactivateTP", 2f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //alreadyTeleported = false;
        print("out");
        //Invoke("reactivateTP", 2f);
    }

    void reactivateTP()
    {
        //objCollider.enabled = true;
        portalScript.enabled = true;
        print("waiting");
        //alreadyTeleported = false;
    }
}
