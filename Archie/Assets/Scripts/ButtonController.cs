using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button button;
    public Text text;
    [SerializeField] int lowestValue = 0;
    [SerializeField] int highestValue = 10;

    public void pullNumber()
    {
        int randomNumber = Random.Range(lowestValue, highestValue);
        if (randomNumber == 1) {
            unlockhandler.Unlock_1 = true;
        }
        else if (randomNumber == 2)
        {
            unlockhandler.Unlock_2 = true;
        }
        else if (randomNumber == 3)
        {
            unlockhandler.Unlock_3 = true;
        }
        else if (randomNumber == 4)
        {
            unlockhandler.Unlock_4 = true;
        }
        else if (randomNumber == 5)
        {
            unlockhandler.Unlock_5 = true;
        }
        else if (randomNumber == 6)
        {
            unlockhandler.Unlock_6 = true;
        }
        else if (randomNumber == 7)
        {
            unlockhandler.Unlock_7= true;
        }
        else if (randomNumber == 8)
        {
            unlockhandler.Unlock_8 = true;
        }
        else if (randomNumber == 9)
        {
            unlockhandler.Unlock_9 = true;
        }
        else if (randomNumber == 10)
        {
            unlockhandler.Unlock_10 = true;
        }
        text.text = randomNumber.ToString();
    }

}
