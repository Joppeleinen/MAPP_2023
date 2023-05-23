using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotocollection : MonoBehaviour
{
    [SerializeField] int collectionScene = 1;
    public AudioSource audio;
    public AudioClip clip;
    bool LoadingInitiated = false;


    public void goToCollectionPressed()
    {
        if (!LoadingInitiated)
        {
            StartCoroutine(DelayedLoad("Collection"));
            LoadingInitiated = true;
        }
    }
    IEnumerator DelayedLoad(string thingToLoad)
    {
        //Play the clip once
        audio.PlayOneShot(clip);

        //Wait until clip finish playing
        yield return new WaitForSeconds(clip.length);

        //Load scene here
        Application.LoadLevel(thingToLoad);

    }
}
