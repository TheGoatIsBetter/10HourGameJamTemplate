using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //static (stays same) game manager instance
    public static GameManager instance;
    public static AudioManager audioManager;

    [Header("Lists")]
    public List<PlayerController> players;
    public List<AIController> ais;


    [Header("Screen State Objects")]
    public GameObject titleScreenStateObject;
    public GameObject gameOverStateObject;
    public GameObject mainMenuStateObject;
    public GameObject optionsStateObject;
    public GameObject gameplayStateObject;


    //Awake is called before Start
    private void Awake()
    {
        if (instance == null)
        {
            //this is THE game manager
            instance = this;
            //don't kill it in a new scene.
            DontDestroyOnLoad(gameObject);
        }
        else //this isn't THE game manager
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ActivateTitleScreenState();

        //attach audiomanager to gamemanager
        audioManager = AudioManager.instance;
    }

    //deactivate all gamestates
    private void DeactivateAllStates()
    {
        titleScreenStateObject.SetActive(false);
        gameOverStateObject.SetActive(false);
        mainMenuStateObject.SetActive(false);
        optionsStateObject.SetActive(false);
        gameplayStateObject.SetActive(false);
    }

    public void ActivateTitleScreenState()
    {
        DeactivateAllStates();
        titleScreenStateObject.SetActive(true);
    }

    public void ActivateGameOverState()
    {
        DeactivateAllStates();
        gameOverStateObject.SetActive(true);
    }

    public void ActivateMainMenuState()
    {
        DeactivateAllStates();
        mainMenuStateObject.SetActive(true);
    }

    public void ActivateOptionsState()
    {
        DeactivateAllStates();
        optionsStateObject.SetActive(true);
    }

    public void ActivateGameplayState()
    {
        DeactivateAllStates();
        gameplayStateObject.SetActive(true);
    }
}
