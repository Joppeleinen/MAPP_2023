using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotocollection : MonoBehaviour
{
    [SerializeField] int collectionScene = 1;


    public void goToCollectionPressed()
    {
        SceneManager.LoadScene(collectionScene);
    }
}
