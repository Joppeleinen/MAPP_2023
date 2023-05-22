using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip windSound;
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                audioSource.PlayOneShot(windSound);
                PlayerMovement pm = player.GetComponent<PlayerMovement>();
                //pm.leftWind();
            }
        }
    }
}
