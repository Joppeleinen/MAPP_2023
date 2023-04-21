using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitfromshop : MonoBehaviour
{
    [SerializeField] int LevelToLoad = 0;


    public void exitFromStore()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
