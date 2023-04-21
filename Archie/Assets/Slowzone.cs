using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowzone : MonoBehaviour
{
    public float slowMultiplier = 0.6f; //ta 0.5f om den ska bli hälften så snabb. 


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject player = GameObject.FindWithTag("Player");
            if(player != null)
            {
                
                player.GetComponent<PlayerMovement>().applyMultiplier(slowMultiplier);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                player.GetComponent<PlayerMovement>().resetMultiplier();
            }
        }
    }





}
