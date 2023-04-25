using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public GameObject loseMenuUI;
    public PlayerMovement lmao;
    public GameObject pauseButton;
    public Spawnpoint startingPoint;

    public void loseLevel()
    {
        loseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void restartLevel()
    {
        Time.timeScale = 1f;

        lmao.respawn();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

    }

    public void restartGameWorld()
    {
        loseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        lmao.respawnFromCheckpoint();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
