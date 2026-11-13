using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuManager : MonoBehaviour
{
    [Header("Scene Settings")]
    public string gameSceneName = "GameLevel"; // Name of actual gameplay scene

    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject optionsPanel; //This is the settings scene

    // for new game button
    public void OnClick_NewGame()
    {
        // loads the first scene in the build index of the specified scene
        SceneManager.LoadScene("NewGame"); // put the exact scene name inside the parenthesis
    }

    // for load game button
    public void OnClick_LoadGame()
    {
        // this loads the saved game
        // for now, let's assume i have a saved game that loads the specified scene.

        Debug.Log("Load Game clicked - loading save data...");
        SceneManager.LoadScene("LoadGame"); // put the exact scene name inside the parenthesis        
    }

    // for options button
    public void Onclick_Options()
    {
        // toggles the options panel
        if (optionsPanel != null)
        {
            mainMenuPanel.SetActive(false);
            optionsPanel.SetActive(true);
        }
    }

    // for quit button
    public void OnClick_Quit()
    {
        #if UNITY_EDITOR
        // stops playing if in the Unity Editor
            UnityEditor.EditorApplication.isPlaying = false;
        
        #else
        // closes the application
            Application.Quit();
        #endif
    }

}

