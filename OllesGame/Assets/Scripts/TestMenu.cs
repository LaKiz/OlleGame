using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMenu : MonoBehaviour
{
    // used to ensure that the launch screen isn't more than once per play session if the project reloads the main scene
    //private static bool alreadyShownThisSession = false;
    //private GameManager gameScript;
    private BoardManager boardScript;
    void Awake()
    {

        /*:
        // have we already shown this once?
        if (alreadyShownThisSession)
        {
            StartGame();
        }
        else
        {
            alreadyShownThisSession = true;

        }*/
        boardScript = GetComponent<BoardManager>();

        InitGame();
        //gameScript = GetComponent<GameManager>();
    }

    /*public void StartGame()
    {
        //gameScript = GetComponent<GameManager>();
        Time.timeScale = 1f;
    }*/


}


