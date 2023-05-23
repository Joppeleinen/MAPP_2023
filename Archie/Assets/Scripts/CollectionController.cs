using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.U2D;

public class CollectionController : MonoBehaviour
{
    public ActiveItemMatrix activeItemMatrix;
    private string activeItemPath;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip interactSound;
    public void Start()
    {
        activeItemPath = $"{Application.persistentDataPath}/ActiveItemMatrix.json";
        if (File.Exists(activeItemPath))
        {
            string json = File.ReadAllText(activeItemPath);
            activeItemMatrix = JsonUtility.FromJson<ActiveItemMatrix>(json);
        }
    }

    public void PressUnlock1()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem1 = true;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem2 = false;
            activeItemMatrix.activeItem4 = false;
            activeItemMatrix.activeItem5 = false;
            activeItemMatrix.activeItem6 = false;
            activeItemMatrix.activeItem7 = false;
            activeItemMatrix.activeItem9 = false;
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
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        SaveJson();
    }
    public void PressUnlock2()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem2 = true;
        activeItemMatrix.activeItem1 = false;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem4 = false;
            activeItemMatrix.activeItem5 = false;
            activeItemMatrix.activeItem6 = false;
            activeItemMatrix.activeItem7 = false;
            activeItemMatrix.activeItem9 = false;
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
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        SaveJson();
    }
    public void PressUnlock3()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem3 = true;
            activeItemMatrix.activeItem8 = false;
            activeItemMatrix.activeItem10 = false;
        activeItemMatrix.activeItemDefault = false;
        ActiveItemHandler.activeUnlock2 = activeItemMatrix.activeItem2;
        ActiveItemHandler.activeUnlock3 = activeItemMatrix.activeItem3;
        ActiveItemHandler.activeUnlock4 = activeItemMatrix.activeItem4;
        ActiveItemHandler.activeUnlock5 = activeItemMatrix.activeItem5;
        ActiveItemHandler.activeUnlock6 = activeItemMatrix.activeItem6;
        ActiveItemHandler.activeUnlock7 = activeItemMatrix.activeItem7;
        ActiveItemHandler.activeUnlock8 = activeItemMatrix.activeItem8;
        ActiveItemHandler.activeUnlock9 = activeItemMatrix.activeItem9;
        ActiveItemHandler.activeUnlock10 = activeItemMatrix.activeItem10;
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        ActiveItemHandler.activeUnlock1 = activeItemMatrix.activeItem1;
        SaveJson();
    }
    public void PressUnlock4()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem4 = true;
        activeItemMatrix.activeItem2 = false;
            activeItemMatrix.activeItem1 = false;
            activeItemMatrix.activeItem5 = false;
            activeItemMatrix.activeItem6 = false;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem7 = false;
            activeItemMatrix.activeItem9 = false;
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
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        SaveJson();
    }
    public void PressUnlock5()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem5 = true;
        activeItemMatrix.activeItem2 = false;
            activeItemMatrix.activeItem4 = false;
            activeItemMatrix.activeItem1 = false;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem6 = false;
            activeItemMatrix.activeItem7 = false;
            activeItemMatrix.activeItem9 = false;
        
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
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        SaveJson();
    }
    public void PressUnlock6()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem6 = true;
        activeItemMatrix.activeItem2 = false;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem4 = false;
            activeItemMatrix.activeItem5 = false;
            activeItemMatrix.activeItem1 = false;
            activeItemMatrix.activeItem7 = false;
            activeItemMatrix.activeItem9 = false;
        
        ActiveItemHandler.activeUnlock2 = activeItemMatrix.activeItem2;
        ActiveItemHandler.activeUnlock3 = activeItemMatrix.activeItem3;
        ActiveItemHandler.activeUnlock4 = activeItemMatrix.activeItem4;
        ActiveItemHandler.activeUnlock5 = activeItemMatrix.activeItem5;
        ActiveItemHandler.activeUnlock6 = activeItemMatrix.activeItem6;
        ActiveItemHandler.activeUnlock7 = activeItemMatrix.activeItem7;
        ActiveItemHandler.activeUnlock8 = activeItemMatrix.activeItem8;
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        ActiveItemHandler.activeUnlock9 = activeItemMatrix.activeItem9;
        ActiveItemHandler.activeUnlock10 = activeItemMatrix.activeItem10;
        ActiveItemHandler.activeUnlock1 = activeItemMatrix.activeItem1;
        SaveJson();
    }
    public void PressUnlock7()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem7 = true;
        activeItemMatrix.activeItem2 = false;            
        activeItemMatrix.activeItem4 = false;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem5 = false;
            activeItemMatrix.activeItem6 = false;
            activeItemMatrix.activeItem1 = false;
            activeItemMatrix.activeItem9 = false;
        
        ActiveItemHandler.activeUnlock2 = activeItemMatrix.activeItem2;
        ActiveItemHandler.activeUnlock3 = activeItemMatrix.activeItem3;
        ActiveItemHandler.activeUnlock4 = activeItemMatrix.activeItem4;
        ActiveItemHandler.activeUnlock5 = activeItemMatrix.activeItem5;
        ActiveItemHandler.activeUnlock6 = activeItemMatrix.activeItem6;
        ActiveItemHandler.activeUnlock7 = activeItemMatrix.activeItem7;
        ActiveItemHandler.activeUnlock8 = activeItemMatrix.activeItem8;
        ActiveItemHandler.activeUnlock9 = activeItemMatrix.activeItem9;
        ActiveItemHandler.activeUnlock10 = activeItemMatrix.activeItem10;
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        ActiveItemHandler.activeUnlock1 = activeItemMatrix.activeItem1;
        SaveJson();
    }

    public void PressUnlock8()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem8 = true;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem3 = false;
            activeItemMatrix.activeItem10 = false;
        
        ActiveItemHandler.activeUnlock2 = activeItemMatrix.activeItem2;
        ActiveItemHandler.activeUnlock3 = activeItemMatrix.activeItem3;
        ActiveItemHandler.activeUnlock4 = activeItemMatrix.activeItem4;
        ActiveItemHandler.activeUnlock5 = activeItemMatrix.activeItem5;
        ActiveItemHandler.activeUnlock6 = activeItemMatrix.activeItem6;
        ActiveItemHandler.activeUnlock7 = activeItemMatrix.activeItem7;
        ActiveItemHandler.activeUnlock8 = activeItemMatrix.activeItem8;
        ActiveItemHandler.activeUnlock9 = activeItemMatrix.activeItem9;
        ActiveItemHandler.activeUnlock10 = activeItemMatrix.activeItem10;
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        ActiveItemHandler.activeUnlock1 = activeItemMatrix.activeItem1;
        SaveJson();
    }
    public void PressUnlock9()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem9 = true;
        activeItemMatrix.activeItem2 = false;
        activeItemMatrix.activeItemDefault = false;
        activeItemMatrix.activeItem4 = false;
            activeItemMatrix.activeItem5 = false;
            activeItemMatrix.activeItem6 = false;
            activeItemMatrix.activeItem7 = false;
            activeItemMatrix.activeItem1 = false;
        
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
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        SaveJson();
    }
    public void PressUnlock10()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItem10 = true;
            activeItemMatrix.activeItem3 = false;
            activeItemMatrix.activeItem8 = false;
        activeItemMatrix.activeItemDefault = false;
        ActiveItemHandler.activeUnlock2 = activeItemMatrix.activeItem2;
        ActiveItemHandler.activeUnlock3 = activeItemMatrix.activeItem3;
        ActiveItemHandler.activeUnlock4 = activeItemMatrix.activeItem4;
        ActiveItemHandler.activeUnlock5 = activeItemMatrix.activeItem5;
        ActiveItemHandler.activeUnlock6 = activeItemMatrix.activeItem6;
        ActiveItemHandler.activeUnlock7 = activeItemMatrix.activeItem7;
        ActiveItemHandler.activeUnlock8 = activeItemMatrix.activeItem8;
        ActiveItemHandler.activeUnlock9 = activeItemMatrix.activeItem9;
        ActiveItemHandler.activeUnlock10 = activeItemMatrix.activeItem10;
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        ActiveItemHandler.activeUnlock1 = activeItemMatrix.activeItem1;
        SaveJson();
    }
    public void PressUnlockDefault()
    {
        audioSource.PlayOneShot(interactSound);
        activeItemMatrix.activeItemDefault = true;
        activeItemMatrix.activeItem10 = false;
        activeItemMatrix.activeItem1 = false;
        activeItemMatrix.activeItem2= false;
        activeItemMatrix.activeItem4 = false;
        activeItemMatrix.activeItem5 = false;
        activeItemMatrix.activeItem6 = false;
        activeItemMatrix.activeItem7 = false;
        activeItemMatrix.activeItem9 = false;
        activeItemMatrix.activeItem3 = false;
        activeItemMatrix.activeItem8 = false;
        ActiveItemHandler.activeUnlock2 = activeItemMatrix.activeItem2;
        ActiveItemHandler.activeUnlock3 = activeItemMatrix.activeItem3;
        ActiveItemHandler.activeUnlock4 = activeItemMatrix.activeItem4;
        ActiveItemHandler.activeUnlock5 = activeItemMatrix.activeItem5;
        ActiveItemHandler.activeUnlock6 = activeItemMatrix.activeItem6;
        ActiveItemHandler.activeUnlock7 = activeItemMatrix.activeItem7;
        ActiveItemHandler.activeUnlock8 = activeItemMatrix.activeItem8;
        ActiveItemHandler.activeUnlock9 = activeItemMatrix.activeItem9;
        ActiveItemHandler.activeUnlockDefault = activeItemMatrix.activeItemDefault;
        ActiveItemHandler.activeUnlock10 = activeItemMatrix.activeItem10;
        ActiveItemHandler.activeUnlock1 = activeItemMatrix.activeItem1;
        SaveJson();
    }
    private void SaveJson()
    {
        string json = JsonUtility.ToJson(activeItemMatrix);
        File.WriteAllText(activeItemPath, json);
    }

}

