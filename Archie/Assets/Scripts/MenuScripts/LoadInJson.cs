using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.U2D;

public class LoadInJson : MonoBehaviour
{
    public ActiveItemMatrix activeItemMatrix;
    public CoinMatrix coinMatrix;
    public GyroMatrix gyroMatrix;
    private string coinMatrixPath;
    private string activeItemPath;
    private string gyroMatrixPath;
    public UnlockableMatrix unlockableMatrix;
    private string unlockMatrixPath;
    void Start()
    {
        activeItemPath = $"{Application.persistentDataPath}/ActiveItemMatrix.json";
        if (File.Exists(activeItemPath))
        {
            string json = File.ReadAllText(activeItemPath);
            activeItemMatrix = JsonUtility.FromJson<ActiveItemMatrix>(json);
        }
        ActiveItemHandler.activeUnlock2 = activeItemMatrix.activeItem2;
        ActiveItemHandler.activeUnlock3 = activeItemMatrix.activeItem3;
        ActiveItemHandler.activeUnlock4 = activeItemMatrix.activeItem4;
        ActiveItemHandler.activeUnlock5 = activeItemMatrix.activeItem5;
        ActiveItemHandler.activeUnlock6 = activeItemMatrix.activeItem6;
        ActiveItemHandler.activeUnlock7 = activeItemMatrix.activeItem7;
        ActiveItemHandler.activeUnlock8 = activeItemMatrix.activeItem8;
        ActiveItemHandler.activeUnlock9 = activeItemMatrix.activeItem9;
        ActiveItemHandler.activeUnlock10 = activeItemMatrix.activeItem10;
        ActiveItemHandler.activeUnlock1 = activeItemMatrix.activeItem1;
        gyroMatrixPath = $"{Application.persistentDataPath}/GyroMatrix.json";
        if (File.Exists(gyroMatrixPath))
        {
            string json = File.ReadAllText(gyroMatrixPath);
            gyroMatrix = JsonUtility.FromJson<GyroMatrix>(json);
        }
        GyroHandler.GyroActivated = gyroMatrix.gyroActivated;
        unlockMatrixPath = $"{Application.persistentDataPath}/UnlockMatrix.json";

        if (File.Exists(unlockMatrixPath))
        {
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
        if (File.Exists(coinMatrixPath))
        {
            string json = File.ReadAllText(coinMatrixPath);
            coinMatrix = JsonUtility.FromJson<CoinMatrix>(json);
            CoinHandler.CoinsAquired = coinMatrix.coinsSaved;
        }
        else {

            CoinHandler.CoinsAquired = 0;
        }
    }
}

