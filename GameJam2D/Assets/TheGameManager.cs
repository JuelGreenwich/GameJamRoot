using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGameManager : MonoBehaviour
{
    //portal
    public bool hasTeleported;

    //Button for roots
    public GameObject ButtonRoots;
    public bool buttonRootsPressed;

    //Button for platforms
    public GameObject ButtonPlatforms;
    public bool buttonPlatformsPressed;

    [SerializeField] List<GameObject> platforms;

    //Linked Buttons
    public GameObject LinkedButton1;
    public GameObject LinkedButton2;
    public bool linkedButton1Pressed;
    public bool linkedButton2Pressed;
    [SerializeField] GameObject finalDoor;


    void Start()
    {
        ButtonRoots = GameObject.Find("ButtonRoots");
        ButtonPlatforms = GameObject.Find("ButtonPlatforms");
        LinkedButton1 = GameObject.Find("LinkedButton1");
        LinkedButton2 = GameObject.Find("LinkedButton2");
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonRoots != null)
        buttonRootsPressed = ButtonRoots.GetComponent<Button>().pressed;

        if (ButtonPlatforms != null)
        buttonPlatformsPressed = ButtonPlatforms.GetComponent<Button>().pressed;
        
        //print(buttonPlatformsPressed);

        if(buttonPlatformsPressed)
        {
            foreach(GameObject i in platforms)
            {
                i.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject i in platforms)
            {
                i.SetActive(false);
            }
        }

        if (LinkedButton1 != null)
        linkedButton1Pressed = LinkedButton1.GetComponent<Button>().pressed;

        if (LinkedButton2 != null)
        linkedButton2Pressed = LinkedButton2.GetComponent<Button>().pressed;

        if(linkedButton1Pressed && linkedButton2Pressed)
        {
            Destroy(finalDoor);
        }
    }
}
