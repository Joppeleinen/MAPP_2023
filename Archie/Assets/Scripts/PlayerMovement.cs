using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject startingPoint; 

    Rigidbody2D rb;
    float dirX;
    public float moveSpeed = 20f;
    float fixedSpeed = 20f; 
    public Boolean hasGyro = false;
    public Scrollbar scrollbar;
    public float maximumVelocity = 20f;
    float number = 0;

    //private float slowDownFactor = 0.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        respawn();
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

    public void setControlls(Boolean tobble)
    {
        hasGyro = tobble;  
    }

    public void respawn()
    {
        transform.position = startingPoint.transform.position;
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
        
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Sap")) {
            moveSpeed *= slowDownFactor;
            Debug.Log(moveSpeed);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Sap"))
        {
            moveSpeed /= slowDownFactor;
            Debug.Log(moveSpeed);
        }
    }*/
}