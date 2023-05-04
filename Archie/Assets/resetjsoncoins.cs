using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class resetjsoncoins : MonoBehaviour
{
    public CoinMatrix coinMatrix;
    private string coinMatrixPath;
    public void Start()
    {
        coinMatrixPath = $"{Application.persistentDataPath}/CoinMatrix.json";
        if (File.Exists(coinMatrixPath))
        {
            string json = File.ReadAllText(coinMatrixPath);
            coinMatrix = JsonUtility.FromJson<CoinMatrix>(json);
        }
        CoinHandler.CoinsAquired = coinMatrix.coinsSaved;
    }

    // Update is called once per frame
    public void ResetJson()
    {
        CoinHandler.CoinsAquired = 0;
        coinMatrix.coinsSaved = 0;
        SaveJson();
    }
    private void SaveJson()
    {
        string json = JsonUtility.ToJson(coinMatrix);
        File.WriteAllText(coinMatrixPath, json);
    }
}
