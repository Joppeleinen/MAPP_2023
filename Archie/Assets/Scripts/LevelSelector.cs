using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip interactSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenScene()
    {
        audioSource.PlayOneShot(interactSound);
        SceneManager.LoadScene("Level " + level.ToString());

    }
}
