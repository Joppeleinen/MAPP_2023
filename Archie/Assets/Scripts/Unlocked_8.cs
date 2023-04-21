using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_8 : MonoBehaviour
{
    [SerializeField] Button button_8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_8 == true) {
            button_8.interactable = true;
        }
        
    }
}
