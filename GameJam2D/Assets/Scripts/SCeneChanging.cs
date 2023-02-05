using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCeneChanging : MonoBehaviour
{
    public string levelToLoad = "SampleScene";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player1" && gameObject.tag == "Player2")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
