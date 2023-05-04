using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public UnlockableMatrix unlockableMatrix;
    public CoinMatrix coinMatrix;
    public Button button;
    public Text text;
    [SerializeField] int lowestValue = 0;
    [SerializeField] int highestValue = 10;
    [SerializeField] Image image_Original;
    [SerializeField] Sprite image_1;
    [SerializeField] Sprite image_2;
    [SerializeField] Sprite image_3;
    [SerializeField] Sprite image_4;
    [SerializeField] Sprite image_5;
    [SerializeField] Sprite image_6;
    [SerializeField] Sprite image_7;
    [SerializeField] Sprite image_8;
    [SerializeField] Sprite image_9;
    [SerializeField] Sprite image_10;
    [SerializeField] Text pointstext;
    public int score = CoinHandler.CoinsAquired;

    private string unlockMatrixPath;
    private string coinMatrixPath;

    public void Start()
    {
        pointstext.text = "POINTS( " + score + " )";
        unlockMatrixPath = $"{Application.persistentDataPath}/UnlockMatrix.json";

        if (File.Exists(unlockMatrixPath)) { 
        string json = File.ReadAllText(unlockMatrixPath);
        unlockableMatrix = JsonUtility.FromJson<UnlockableMatrix>(json);
        }

        unlockhandler.Unlock_1 = unlockableMatrix.unlock_1;
        unlockhandler.Unlock_2 = unlockableMatrix.unlock_2;
        unlockhandler.Unlock_3 = unlockableMatrix.unlock_3;
        unlockhandler.Unlock_4 = unlockableMatrix.unlock_4;
        unlockhandler.Unlock_5 = unlockableMatrix.unlock_5;
        unlockhandler.Unlock_6 = unlockableMatrix.unlock_6;
        unlockhandler.Unlock_7 = unlockableMatrix.unlock_7;
        unlockhandler.Unlock_8 = unlockableMatrix.unlock_8;
        unlockhandler.Unlock_9 = unlockableMatrix.unlock_9;
        unlockhandler.Unlock_10 = unlockableMatrix.unlock_10;
         coinMatrixPath = $"{Application.persistentDataPath}/CoinMatrix.json";

        if (File.Exists(coinMatrixPath)) { 
        string json = File.ReadAllText(coinMatrixPath);
        coinMatrix = JsonUtility.FromJson<CoinMatrix>(json);
        CoinHandler.CoinsAquired = coinMatrix.coinsSaved;
        }
        else
        {
            CoinHandler.CoinsAquired = 0;
        }
    }

    public void pullNumber()
    {
        if (score >= 10)
        {
            score = score - 10;
            int randomNumber = Random.Range(lowestValue, highestValue);
            coinMatrix.coinsSaved = coinMatrix.coinsSaved - 10;
            CoinHandler.CoinsAquired = CoinHandler.CoinsAquired - 10;
            if (randomNumber == 1)
            {
                unlockableMatrix.unlock_1 = true;
                unlockhandler.Unlock_1 = true;
                image_Original.sprite = image_1;
            }
            else if (randomNumber == 2)
            {
                unlockableMatrix.unlock_2 = true;
                unlockhandler.Unlock_2 = true;
                image_Original.sprite = image_2;
            }
            else if (randomNumber == 3)
            {
                unlockableMatrix.unlock_3 = true;
                unlockhandler.Unlock_3 = true;
                image_Original.sprite = image_3;
            }
            else if (randomNumber == 4)
            {
                unlockableMatrix.unlock_4 = true;
                unlockhandler.Unlock_4 = true;
                image_Original.sprite = image_4;
            }
            else if (randomNumber == 5)
            {
                unlockableMatrix.unlock_5 = true;
                unlockhandler.Unlock_5 = true;
                image_Original.sprite = image_5;
            }
            else if (randomNumber == 6)
            {
                unlockableMatrix.unlock_6 = true;
                unlockhandler.Unlock_6 = true;
                image_Original.sprite = image_6;
            }
            else if (randomNumber == 7)
            {
                unlockableMatrix.unlock_7 = true;
                unlockhandler.Unlock_7 = true;
                image_Original.sprite = image_7;
            }
            else if (randomNumber == 8)
            {
                unlockableMatrix.unlock_8 = true;
                unlockhandler.Unlock_8 = true;
                image_Original.sprite = image_8;
            }
            else if (randomNumber == 9)
            {
                unlockableMatrix.unlock_9 = true;
                unlockhandler.Unlock_9 = true;
                image_Original.sprite = image_9;
            }
            else if (randomNumber == 10)
            {
                unlockableMatrix.unlock_10 = true;
                unlockhandler.Unlock_10 = true;
                image_Original.sprite = image_10;
            }
            text.text = randomNumber.ToString();
        }
        else {
            text.text = "Not enough!";
        }
        pointstext.text = "POINTS( " + score + " )";
        SaveJson();
        SaveJsonCoin();
    }
    private void SaveJson()
    {
        string json = JsonUtility.ToJson(unlockableMatrix);
        File.WriteAllText(unlockMatrixPath, json);
    }
    private void SaveJsonCoin()
    {
        string json = JsonUtility.ToJson(coinMatrix);
        File.WriteAllText(coinMatrixPath, json);
    }

}
