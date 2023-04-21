using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_3 : MonoBehaviour
{
    [SerializeField] Button button_3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_3 == true) {
            button_3.interactable = true;
        }
        
    }
}
