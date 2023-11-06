using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load2_3 : MonoBehaviour
{
    public GameObject newgameObject;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("end2"))
        {
            SceneManager.LoadScene("level03");
        }

    }
}
