using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_5 : MonoBehaviour
{
    [SerializeField] Button button_5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_5 == true) {
            button_5.interactable = true;
        }
        
    }
}
