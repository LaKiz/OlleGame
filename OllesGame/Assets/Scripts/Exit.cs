﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void ExitGame()
    {
        //SceneManager.LoadScene(0);
        Application.LoadLevel(0);
    }



}
