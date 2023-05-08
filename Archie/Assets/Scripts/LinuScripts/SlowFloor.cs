using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowFloor : MonoBehaviour
{

    public float slowDownFactor = 0.5f;
    private PlayerMovement playerMovement;
    [SerializeField] private RollingEnemy rollingEnemy;

    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerMovement.applyMultiplier(slowDownFactor);
        }
        if (other.gameObject.CompareTag("EffectedEnemy"))
        {
            rollingEnemy.applyMultiplier(slowDownFactor);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerMovement.resetMultiplier();
        }
        if (other.gameObject.CompareTag("EffectedEnemy"))
        {
            rollingEnemy.resetMultiplier();
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponent<PlayerMovement>().moveSpeed /= 2;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponent<PlayerMovement>().moveSpeed *= 2;
        }
    }*/
}
