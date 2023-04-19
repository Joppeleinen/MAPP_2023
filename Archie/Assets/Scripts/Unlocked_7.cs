using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_7 : MonoBehaviour
{
    [SerializeField] Button button_7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_7 == true) {
            button_7.interactable = true;
        }
        
    }
}
