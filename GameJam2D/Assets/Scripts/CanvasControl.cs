using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasControl : MonoBehaviour
{
    public GameObject canvas;
    public GameObject tileMapCanvas;

    public string levelToLoad = "RestartLevelName";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            tileMapCanvas.SetActive(true);
            canvas.SetActive(true);
        }
    }

    public void Restart()
    {
        FindObjectOfType<AudioManager>().PlayAudio("Click");
        Invoke("LoadScene", 0.5f);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
