using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public bool gameIsPaused = false;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip interactSound;

    public GameObject pauseMenuUI;

    // Update is called once per frame lol
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }  
    }
    public void Resume ()
    {
        audioSource.PlayOneShot(interactSound);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause ()
    {
        audioSource.PlayOneShot(interactSound);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMainMenu()
    {
        audioSource.PlayOneShot(interactSound);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

}
