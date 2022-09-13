using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    //Resets and restarts game
    public void RestartGameButton()
    {
        //TODO: switch game state
    }

    //returns to main menu
    public void MainMenuButton()
    {
        GameManager.instance.ActivateMainMenuState();
    }

    //quits the game
    public void QuitGameButton()
    {
        Application.Quit();
    }
}