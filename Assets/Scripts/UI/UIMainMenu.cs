using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    //Resets and starts game
    public void StartGameButton()
    {
        //TODO: switch game state
    }

    //opens options menu
    public void OptionsButton()
    {
        GameManager.instance.ActivateOptionsState();
    }

    //quits the game
    public void QuitGameButton()
    {
        Application.Quit();
    }
}
