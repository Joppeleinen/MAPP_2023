using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ResetJsonCollections : MonoBehaviour
{
    public UnlockableMatrix unlockableMatrix;
    private string unlockMatrixPath;
    public void Start()
    {
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
    }

    public void ResetJson(){
    unlockableMatrix.unlock_1 = false;
    unlockhandler.Unlock_1 = false;
    unlockableMatrix.unlock_2 = false;
    unlockhandler.Unlock_2 = false;
    unlockableMatrix.unlock_3 = false;
    unlockhandler.Unlock_3 = false;
    unlockableMatrix.unlock_4 = false;
    unlockhandler.Unlock_4 = false;
    unlockableMatrix.unlock_5 = false;
    unlockhandler.Unlock_5 = false;
    unlockableMatrix.unlock_6 = false;
    unlockhandler.Unlock_6 = false;
    unlockableMatrix.unlock_7 = false;
    unlockhandler.Unlock_7 = false;
    unlockableMatrix.unlock_8 = false;
    unlockhandler.Unlock_8 = false;
    unlockableMatrix.unlock_9 = false;
    unlockhandler.Unlock_9 = false;
    unlockableMatrix.unlock_10 = false;
    unlockhandler.Unlock_10 = false;
        SaveJson();
}
    private void SaveJson()
    {
        string json = JsonUtility.ToJson(unlockableMatrix);
        File.WriteAllText(unlockMatrixPath, json);
    }
}