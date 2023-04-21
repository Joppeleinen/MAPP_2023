using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Spawnpoint startingPoint;

    Rigidbody2D rb;
    float dirX;
    public float moveSpeed = 20f;
    float fixedSpeed = 10f;
    public Boolean hasGyro = false;
    public Scrollbar scrollbar;
    float number = 0;
    public float speedMultiplier = 1f;


    // Start is called before the first frame update
    void Start()
    {
        if (hasGyro)
        {
            Input.gyro.enabled = true;
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
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
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
            rb.velocity = new Vector2(dirX, 0f);
        }
        else
        {
            rb.velocity = new Vector2(number, 0f);
        }

    }
    private void moveWithScroll()
    {

        number = ((scrollbar.value * moveSpeed) - 5) / 1.5f;
        number = speedMultiplier;

    }

    public void applyMultiplier(float multiplier)
    {
        speedMultiplier = multiplier;

    }
    public void resetMultiplier()
    {
        speedMultiplier = 1f;
    }

    public void applyMultiplier(float multiplier)
    {
        speedMultiplier *= multiplier;

    }
    public void resetMultiplier()
    {
        speedMultiplier = 1f; 
    }
}