using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocked_1 : MonoBehaviour
{
    [SerializeField] Button button_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockhandler.Unlock_1 == true) {
            button_1.interactable = true;
        }
        
    }
}
