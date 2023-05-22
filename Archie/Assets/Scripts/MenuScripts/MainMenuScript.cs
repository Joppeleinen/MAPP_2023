using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip interactSound;
    bool LoadingInitiated = false;

    public void LoadMainMenu()
    {
        if (!LoadingInitiated)
        {
            StartCoroutine(DelayedLoad("MainMenu"));
            LoadingInitiated = true;
        }
    }

    public void StartGame()
    {
        if (!LoadingInitiated)
        {
            StartCoroutine(DelayedLoad("Level1"));
            LoadingInitiated = true;
        }
    }

    public void OpenLevelSelector()
    {
        if (!LoadingInitiated)
        {
            StartCoroutine(DelayedLoad("LevelSelect"));
            LoadingInitiated = true;
        }
    }

    public void OpenSettings()
    {
        if (!LoadingInitiated)
        {
            StartCoroutine(DelayedLoad("SettingsMenu"));
            LoadingInitiated = true;
        }
    }

    public void OpenStore()
    {
        if (!LoadingInitiated)
        {
            StartCoroutine(DelayedLoad("Store"));
            LoadingInitiated = true;
        }
    }
    public void OpenCredits()
    {

        if (!LoadingInitiated)
        {
            StartCoroutine(DelayedLoad("Credits"));
            LoadingInitiated = true;
        }
    }
    public void QuitGame()
    {
        audioSource.PlayOneShot(interactSound);
        Application.Quit();
    }
    IEnumerator DelayedLoad(string thingToLoad)
    {
        //Play the clip once
        audioSource.PlayOneShot(interactSound);

        //Wait until clip finish playing
        yield return new WaitForSeconds(interactSound.length);

        //Load scene here
        Application.LoadLevel(thingToLoad);

    }
    IEnumerator DelayedLoadInt(int thingToLoad)
    {
        //Play the clip once
        audioSource.PlayOneShot(interactSound);

        //Wait until clip finish playing
        yield return new WaitForSeconds(interactSound.length);

        //Load scene here
        Application.LoadLevel(thingToLoad);

    }
}
