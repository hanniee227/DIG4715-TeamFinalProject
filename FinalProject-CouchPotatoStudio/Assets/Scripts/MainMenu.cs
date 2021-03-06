﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public UnityEngine.UI.Button continueButton;

    void Start()
    {
		if (PlayerPrefs.GetInt("save", 0) == 0) //if there is no save data, disable the continue button
        {
            continueButton.interactable = false;
        }
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    //===Functions=====
    public void NewGame() //selecting this option should reset all non-settings PlayerPrefs (save data)
    {
        Time.timeScale = 1f; //unfreeze the game (incase they decided to play AFTER going main menu from pause menu)
        PlayerPrefs.SetInt("save", 0);
        PlayerPrefs.SetInt("stage1", 0);
        PlayerPrefs.SetInt("stage2", 0);
        PlayerPrefs.SetInt("stage3", 0);
        PlayerPrefs.SetInt("seenEnd", 0);
        SceneManager.LoadScene("HUB");
    }
    public void PlayGame()
    {
        Time.timeScale = 1f; //unfreeze the game (incase they decided to play AFTER going main menu from pause menu)
        SceneManager.LoadScene("HUB");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting From Main");
        Application.Quit();
    }

    public void LoadStage()
    {
        Time.timeScale = 1f; //unfreeze the game (incase they decided to play AFTER going main menu from pause menu)
        SceneManager.LoadScene("Stage1");
    }
}
