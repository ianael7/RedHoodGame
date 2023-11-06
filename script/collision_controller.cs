using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_controller : MonoBehaviour
{

    public GameObject newgameObject;
    public GameObject newgameObjecttarget;
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("end"))
        {
            newgameObject.SetActive(false);
            newgameObjecttarget.SetActive(false);
        }

    }
}
