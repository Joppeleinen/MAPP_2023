using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(5);
    }

    public void OpenLevelSelector()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void OpenStore()
    {
        SceneManager.LoadScene("Store");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
