using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over_Controller : MonoBehaviour
{
    public GameObject gameOverUI;

    public void RetryButton() //recommencer le niveau
    {
        //recharge la scene
        //remmettre le joueur au spone
        //reactive les mouvements du joueur
        //le remettre en setActive true

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
    }
    public void MainMenuButton() // retour au menu principal
    {

    }
    public void QuitButton() //fermer le jeu
    {
        Application.Quit();
    }
}
