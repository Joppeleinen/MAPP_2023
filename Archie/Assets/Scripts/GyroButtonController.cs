using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GyroButtonController : MonoBehaviour{
    public GyroMatrix gyroMatrix;
    public Button button;
    private string gyroMatrixPath;
    public Image image;
    public Sprite check;
    public Sprite cross;




    public void Start()
    {

        gyroMatrixPath = $"{Application.persistentDataPath}/GyroMatrix.json";
        if (File.Exists(gyroMatrixPath))
        {
            string json = File.ReadAllText(gyroMatrixPath);
            gyroMatrix = JsonUtility.FromJson<GyroMatrix>(json);
        }
        if (GyroHandler.GyroActivated == true)
        {
            image.sprite = check;
        }
        if(GyroHandler.GyroActivated == false)
        {
            image.sprite = cross;
        }
    }

    public void toggleGyro()
    {
        if (GyroHandler.GyroActivated == true)
        {
            GyroHandler.GyroActivated = false;
            image.sprite = check;

        }
        else {
            GyroHandler.GyroActivated = true;
            image.sprite = cross;
        }
        SaveJson();
    }

    private void SaveJson() { 
    string json = JsonUtility.ToJson(gyroMatrix);
    File.WriteAllText(gyroMatrixPath, json);
    }

}
