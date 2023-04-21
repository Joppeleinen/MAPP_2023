using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_6 : MonoBehaviour
{
    [SerializeField] Button button_6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_6 == true) {
            button_6.interactable = true;
        }
        
    }
}
