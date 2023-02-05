using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    private bool BigRabbitEnter = false;
    private bool SmallRabbitEnter = false;

    public void Update()
    {
        if (BigRabbitEnter == true && SmallRabbitEnter == true)
        {
            SceneManager.LoadScene("ThankYouScene");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            BigRabbitEnter = true;
        }
        if (collision.gameObject.name == "Player2")
        {
            SmallRabbitEnter = true;
        }

    }
}
