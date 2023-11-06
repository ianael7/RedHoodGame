using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverButton : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject newgameObject;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("end"))
        {
            newgameObject.SetActive(false);
            gameOverUI.SetActive(true);
        }

    }
}
