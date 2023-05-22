using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public GameObject loseMenuUI;
    public PlayerMovement playerMov;
    public GameObject pauseButton;
    public Spawnpoint startingPoint;
    public RespawnBlock block;

    public List<GameObject> blockList;
    public void loseLevel()
    {
        loseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void restartLevel()
    {
        Time.timeScale = 1f;
        playerMov.respawn();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }

    public void restartGameWorld()
    {
        loseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        block.respawnFromCheckpoint();
        playerMov.respawnFromCheckpoint();
    }
    // Update is called once per frame


    public void restartLevelFromStart()
    {
        Time.timeScale = 1f;

        playerMov.respawn();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void restartLevelFromLatestCheckPoint()
    {
        loseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        playerMov.respawnFromCheckpoint();
        respawnBoxes();
    }
    void Update()
    {

    }
    public void respawnBoxes()
    {
        foreach(GameObject box in blockList){
            box.GetComponent<RespawnBlock>().respawnFromCheckpoint();
        }
    }
    public void addBox(GameObject box)
    {
        blockList.Add(box);

    }
}
