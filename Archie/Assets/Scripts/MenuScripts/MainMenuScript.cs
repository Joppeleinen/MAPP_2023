using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip interactSound;

    public void LoadMainMenu()
    {
        audioSource.PlayOneShot(interactSound);
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        audioSource.PlayOneShot(interactSound);
        SceneManager.LoadScene(5);
    }

    public void OpenLevelSelector()
    {
        audioSource.PlayOneShot(interactSound);
        SceneManager.LoadScene("LevelSelect");
    }

    public void OpenSettings()
    {
        audioSource.PlayOneShot(interactSound);
        SceneManager.LoadScene("SettingsMenu");
    }

    public void OpenStore()
    {
        audioSource.PlayOneShot(interactSound);
        SceneManager.LoadScene("Store");
    }
    public void OpenCredits()
    {
        audioSource.PlayOneShot(interactSound);
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame()
    {
        audioSource.PlayOneShot(interactSound);
        Application.Quit();
    }
}
