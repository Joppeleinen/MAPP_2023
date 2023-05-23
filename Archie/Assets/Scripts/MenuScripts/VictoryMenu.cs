using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{

    public bool gameIsWon = false;

    public GameObject winMenuUI;

    public GameObject pauseButton;

    public playAudio playAudio;

    public int level;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip winSound;
    [SerializeField] private AudioClip interactSound;

    [SerializeField]   private float secondsBeforeWinScreen = 0.15f;

    [SerializeField] private float slowmotionFactor = 0.1f;

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(secondsBeforeWinScreen); //slowmo time
        Debug.Log("Waiting");
        winMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;

    }
 
    public void Win()
    {
        Time.timeScale = slowmotionFactor; //slowmo
        Debug.Log("SlowedDown");
        StartCoroutine(WaitForSeconds()); //slowmo
        
        
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameIsWon = true;
            audioSource.PlayOneShot(winSound);

            Win();
        }

    }

    public void nextLevel()
    {
        audioSource.PlayOneShot(interactSound);
        gameIsWon = false;
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        SceneManager.LoadScene("Level " + level.ToString());
    }

    public void goToMainAfterWin()
    {
        gameIsWon = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

}
