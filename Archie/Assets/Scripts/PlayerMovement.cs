using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PlayerMovement : MonoBehaviour
{
    public Spawnpoint startingPoint;
    public GameObject respawnPosition;
    public LoseMenu restartGame;

    public GyroMatrix gyroMatrix;

    Rigidbody2D rb;
    float dirX;
    public float moveSpeed = 40f;
    float fixedSpeed = 10f;
    public Boolean hasGyro = true;
    public Scrollbar scrollbar;
    public GameObject scrollbarObject;
    float number = 0;
    public float speedMultiplier = 2f;
    private string gyroMatrixPath;
    public float limits = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
        gyroMatrixPath = $"{Application.persistentDataPath}/GyroMatrix.json";
        if (File.Exists(gyroMatrixPath))
        {
            string json = File.ReadAllText(gyroMatrixPath);
            gyroMatrix = JsonUtility.FromJson<GyroMatrix>(json);
            GyroHandler.GyroActivated = gyroMatrix.gyroActivated;
        }
        hasGyro = GyroHandler.GyroActivated;
        respawn(startingPoint.vector2);
        if (hasGyro)
        {
            Input.gyro.enabled = true;
            scrollbar.gameObject.SetActive(false);
        }
        else
        {
            scrollbar.gameObject.SetActive(true);
        }
        moveSpeed = fixedSpeed;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasGyro)
        {
            dirX = Input.acceleration.x * moveSpeed;
            //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -limits, limits), transform.position.y);
            transform.position = new Vector2(transform.position.x, transform.position.y);
        }
        else
        {
            moveWithScroll();
        }
    }

    public void setControlls(Boolean toggle)
    {
        hasGyro = toggle;
    }


    private void FixedUpdate()
    {
        if (hasGyro)
        {
            rb.velocity = new Vector2(dirX, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(number, rb.velocity.y);
        }

    }
    private void moveWithScroll()
    {
        //number = ((scrollbar.value * 10f) - 5) / 1.5f;
        number = (scrollbar.value - 0.5f) * (10f / 1.5f); 
        number *= speedMultiplier;
    }

    public void applyMultiplier(float multiplier)
    {
        speedMultiplier = multiplier;

    }
    public void resetMultiplier()
    {
        speedMultiplier = 2f;
    }

    public void respawn(Vector2 boop)
    {
        transform.position = boop;
        //transform.position = startingPoint.vector2; 
    }

    public void respawn()
    {
        transform.position = startingPoint.vector2;
    }

    public void respawnFromCheckpoint()
    {
        respawn(respawnPosition.transform.position);
        //gameObject.transform.position = respawnPosition.transform.position;
        //restartGame.restartGameWorld();
    }

    public void ChangeRespawnPosition(GameObject newRespawnPosition)
    {
        respawnPosition = newRespawnPosition;
    }
}