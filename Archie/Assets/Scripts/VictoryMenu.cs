using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{

    public static bool gameIsWon = false;

    public GameObject winMenuUI;

    public GameObject pauseButton;

    public int level;

    void Update()
    {
        if (gameIsWon == true)
        {
            Pause();
        }
    }

    public void Pause()
    {
        winMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameIsWon = true;
        }

    }

    public void nextLevel()
    {
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        SceneManager.LoadScene("Level " + level.ToString());
    }

}
