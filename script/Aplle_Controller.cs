using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aplle_Controller : MonoBehaviour
{
    public GameObject newgameObject;
    public GameObject newgameObjecttarget;
    public GameObject newgameObjectGround;
    public GameObject newgameObjectEnd;
    public GameObject newgameObjectEnd1;
    public GameObject newgameObjectEnd2;
    public GameObject newgameObjectEnd3;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("apple"))
        {
            newgameObjecttarget.SetActive(false);
            newgameObjectGround.SetActive(false);
            newgameObjectEnd.SetActive(false);
            newgameObjectEnd1.SetActive(false);
            newgameObjectEnd2.SetActive(false);
            newgameObjectEnd3.SetActive(false);

        }
        if (collision.gameObject.CompareTag("end1"))
        {
            newgameObjectGround.SetActive(true);
        }

    }
}
