﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start()
    {
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuityGame()
    {
        Application.Quit();
    }
}