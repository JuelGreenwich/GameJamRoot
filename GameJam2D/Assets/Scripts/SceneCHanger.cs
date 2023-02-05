using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCHanger : MonoBehaviour
{
    public string levelToLoad = "SampleScene";
    public void Play()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Exit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
