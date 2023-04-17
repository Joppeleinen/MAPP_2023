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
        text.text = randomNumber.ToString();
    }

}
