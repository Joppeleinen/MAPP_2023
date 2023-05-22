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
    public Boolean hasGyro = true;
    public Scrollbar scrollbar;

    Rigidbody2D rb;


    public float baseSpeed = 10f / 1.5f;
    private float speed = 0; // speed = speed * multiplier. 
    public float speedMultiplier = 1f;

    private bool isSlowedBySlowZone = false;
    private float slowZoneSpeed = 1f; 



    private string gyroMatrixPath;

    public bool useAddForce = true;
    public float howQuickToTurnAround = 2f;


    private float respawnFreezePositionTimer = 0f;
    private bool useRespawnFreezePositionTimer = false;

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
        //baseSpeed = fixedSpeed;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasGyro)
        {
            fixSpeed(Input.acceleration.x, true);

            //dirX = Input.acceleration.x * baseSpeed;
            // Jag vet inte om raden under gör något och kan inte testa det. 
            //transform.position = new Vector2(transform.position.x, transform.position.y);

        }
        else
        {
            fixSpeed(scrollbar.value, false);
            //moveWithScroll();
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
            if (useAddForce == false)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y); //var dirX istället för number
            }
            else
            {
                rb.AddForce(new Vector2(speed, rb.velocity.y));
            }
        }
        else
        {
            if (useAddForce == false)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            else
            {
                rb.AddForce(new Vector2(speed, rb.velocity.y));
            }
        }

        // This fixes the momentum on respawn: 
        if (useRespawnFreezePositionTimer == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            FixMomentumOnRespawn();
            respawnFreezePositionTimer += 1f;
            if (respawnFreezePositionTimer >= 10f)
            {

                rb.constraints = RigidbodyConstraints2D.None;
                respawnFreezePositionTimer = 0f;
                useRespawnFreezePositionTimer = false;
            }
        }
    }
    public float updateSpeed(float value, bool usedGyro)
    {
        float speed = value;
        if (usedGyro == false)
        {
            speed -= 0.5f;
        }
        else
        {
            speed /= 2;
        }
        speed *= 2f;
        if(speed < -0.25f)
        {
            speed = -0.25f;
        }
        else if(speed > 0.25f)
        {
            speed = 0.25f;
        }
        speed *= baseSpeed * speedMultiplier * slowZoneMultiplier();
        return speed;
    }

    public float slowZoneMultiplier()
    {
        if (isSlowedBySlowZone)
        {
            return slowZoneSpeed;
        }
        return 1f; 
    }

    private void fixSpeed(float value, bool toggle)
    {
        float retarderMultipler = 1f;
        if (useAddForce == true)
        {
            //detta gör så att man saktar ner snabbare.  
            if (rb.velocity.x > 0 && scrollbar.value < 0.5f)
            {
                retarderMultipler = howQuickToTurnAround;
            }
            else if (rb.velocity.x < 0 && scrollbar.value > 0.5f)
            {
                retarderMultipler = howQuickToTurnAround;
            }
            else
            {
                retarderMultipler = 1f;
            }
        }
        speed = updateSpeed(value, toggle) * retarderMultipler;
    }



    public void applyMultiplier(float multiplier)
    {
        slowZoneSpeed = multiplier;
        isSlowedBySlowZone = true; 

    }
    public void resetMultiplier()
    {
        speedMultiplier = 1f;
        isSlowedBySlowZone = false; 
    }

    public void respawn(Vector2 boop)
    {

        transform.position = boop;

    }

    public void respawn()
    {

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
        scrollbar.value = 0.5f;
        useRespawnFreezePositionTimer = true;
        rb.velocity = Vector2.zero;
    }

    public void ChangeRespawnPosition(GameObject newRespawnPosition)
    {
        respawnPosition = newRespawnPosition;
    }
}