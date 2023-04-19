using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_4 : MonoBehaviour
{
    [SerializeField] Button button_4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_4 == true) {
            button_4.interactable = true;
        }
        
    }
}
