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
    //[SerializeField] GameObject platforms[];
    [SerializeField] List<GameObject> platforms;


    // Start is called before the first frame update
    void Start()
    {
        ButtonRoots = GameObject.Find("ButtonRoots");
        ButtonPlatforms = GameObject.Find("ButtonPlatforms");
    }

    // Update is called once per frame
    void Update()
    {
        buttonRootsPressed = ButtonRoots.GetComponent<Button>().pressed;
        buttonPlatformsPressed = ButtonPlatforms.GetComponent<Button>().pressed;
        print(buttonPlatformsPressed);

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
    }
}
