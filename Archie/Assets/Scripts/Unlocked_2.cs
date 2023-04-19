using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_2 : MonoBehaviour
{
    [SerializeField] Button button_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_2 == true) {
            button_2.interactable = true;
        }
        
    }
}
