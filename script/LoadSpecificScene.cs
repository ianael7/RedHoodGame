using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSpecificScene : MonoBehaviour
{
    /*
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("level02");
        }
    }*/
    public GameObject newgameObject;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("end2"))
        {
            SceneManager.LoadScene("level02");
        }

    }
}
