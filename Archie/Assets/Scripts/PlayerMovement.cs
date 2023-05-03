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
    public float number = 0;
    public float speedMultiplier = 2f;
    private string gyroMatrixPath;
    public float limits = 10f;
    public bool useAddForce = false;
    public float temporalNumber = 5f;

    public float respawnFreezePositionTimer = 0f; 
    public bool useRespawnFreezePositionTimer = false; 
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
            print("Detta är gyrons värde: " + Input.acceleration.x);
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
            // borde nog vara number istället. 
            // move with scroll kan fungera här också. 
        }
        else
        {
            if(useAddForce == false)
            {
                rb.velocity = new Vector2(number, rb.velocity.y);
            }
            else
            {
                rb.AddForce(new Vector2(number, rb.velocity.y));
            }
        }


        // This fixes the momentum on respawn: 
        if(useRespawnFreezePositionTimer == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            FixMomentumOnRespawn();
            respawnFreezePositionTimer += 1f;
            if(respawnFreezePositionTimer >= 10f){
                
                rb.constraints = RigidbodyConstraints2D.None;
                respawnFreezePositionTimer = 0f;
                useRespawnFreezePositionTimer = false; 
            }
        }
        

    }
    private void moveWithScroll()
    {
        float retarderMultipler = 1f; 
        if(useAddForce == false)
        {
            number = giveVariable(scrollbar.value, false);
        }
        else
        {
            //detta bör göra så att man saktar ner snabbare. 
            if(rb.velocity.x > 0 && scrollbar.value < 0.5f)
            {
                retarderMultipler = 2f; 
            }
            else if(rb.velocity.x < 0 && scrollbar.value > 0.5f)
            {
                retarderMultipler = 2f;
            }
            else
            {
                retarderMultipler = 1f; 
            }
            number = giveVariable(scrollbar.value, false) * retarderMultipler;
        }
        
    }

    public float giveVariable(float value, bool usedGyro)
    {
        float number = value; 
        if(usedGyro == false)
        {
            number -= 0.5f; 
        }
        else
        {
            number /= 2; 
        }
        number *= (10f / 1.5f) * speedMultiplier * temporalNumber;
        return number; 
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
        //rb.velocity = new Vector2(1f, 1f);
        transform.position = boop;
        //transform.position = startingPoint.vector2; 
    }

    public void respawn()
    {
        //respawn(startingPoint.vector2);
        transform.position = startingPoint.vector2;

        useRespawnFreezePositionTimer = true;
        scrollbar.value = 0.5f;
        
        rb.velocity = Vector2.zero;
    }

    public void FixMomentumOnRespawn()
    {
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
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