using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    private Button btn;
    private Button lvl2;
    private Button lvl3;
    public GameObject gameOverUI;
    void Start()
    {
        btn = GameObject.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(ButtonSelected);
        lvl2 = GameObject.Find("level2").GetComponent<Button>();
        lvl2.onClick.AddListener(ButtonSelectedlvl2);
        lvl3 = GameObject.Find("level3").GetComponent<Button>();
        lvl3.onClick.AddListener(ButtonSelectedlvl3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtonSelected() //aplliquer quand on clique sur le bouton
    {
        Debug.Log("Vous avez cliquer sur " + btn.name);
        SceneManager.LoadScene("level01");
        gameOverUI.SetActive(false);

    }

    void ButtonSelectedlvl2() //aplliquer quand on clique sur le bouton
    {
        Debug.Log("Vous avez cliquer sur " + btn.name);
        SceneManager.LoadScene("level02");
        gameOverUI.SetActive(false);

    }

    void ButtonSelectedlvl3() //aplliquer quand on clique sur le bouton
    {
        Debug.Log("Vous avez cliquer sur " + btn.name);
        SceneManager.LoadScene("level03");
        gameOverUI.SetActive(false);

    }
}
