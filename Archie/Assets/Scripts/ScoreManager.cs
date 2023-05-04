using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public CoinMatrix coinMatrix;
    public TextMeshProUGUI text;
    private string coinMatrixPath;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        coinMatrixPath = $"{Application.persistentDataPath}/CoinMatrix.json";
        if (File.Exists(coinMatrixPath))
        {
            string json = File.ReadAllText(coinMatrixPath);
            coinMatrix = JsonUtility.FromJson<CoinMatrix>(json);
            CoinHandler.CoinsAquired = coinMatrix.coinsSaved;
        }
        else
        {

            CoinHandler.CoinsAquired = 0;
        }
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore (int coinValue)
    {
        score += coinValue;
        coinMatrix.coinsSaved = coinMatrix.coinsSaved + 1;
        CoinHandler.CoinsAquired = coinMatrix.coinsSaved;
        text.text = "x" + score.ToString();
        SaveJsonCoin();
    }
    private void SaveJsonCoin()
    {
        string json = JsonUtility.ToJson(coinMatrix);
        File.WriteAllText(coinMatrixPath, json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
