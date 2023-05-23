using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GyroButtonController : MonoBehaviour
{
    public GyroMatrix gyroMatrix;
    public Button button;
    private string gyroMatrixPath;
    public Image image;
    public Sprite spriteoff;
    public Sprite spriteon;
    public AudioSource audioSource;
    public AudioClip audio;


    public void Start()
    {
        gyroMatrixPath = $"{Application.persistentDataPath}/GyroMatrix.json";
        if (File.Exists(gyroMatrixPath))
        {
            string json = File.ReadAllText(gyroMatrixPath);
            gyroMatrix = JsonUtility.FromJson<GyroMatrix>(json);
        }
        if (gyroMatrix.gyroActivated == false)
        {
            image.sprite = spriteoff;
        }
        else {
            image.sprite = spriteon;
        }
    }

    public void ToggleGyro()
    {
        if (gyroMatrix.gyroActivated == true)
        {
            gyroMatrix.gyroActivated = false;
            image.sprite = spriteoff;
        }
        else if(gyroMatrix.gyroActivated == false){
            gyroMatrix.gyroActivated = true;
            image.sprite = spriteon;
        }
        audioSource.PlayOneShot(audio);
        GyroHandler.GyroActivated = gyroMatrix.gyroActivated;
        SaveJson();
    }

    private void SaveJson() { 
    string json = JsonUtility.ToJson(gyroMatrix);
    File.WriteAllText(gyroMatrixPath, json);
    }

}
