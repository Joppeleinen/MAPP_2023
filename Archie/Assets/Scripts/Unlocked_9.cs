using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_9 : MonoBehaviour
{
    [SerializeField] Button button_9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_9 == true) {
            button_9.interactable = true;
        }
        
    }
}
