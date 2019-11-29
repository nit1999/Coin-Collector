﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene("testGame");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
