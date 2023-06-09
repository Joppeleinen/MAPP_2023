using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip hurtSound;
    public bool hasBoxCollider;

    public LoseMenu lose;
    public bool respawnImmediately = false; 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                if(respawnImmediately == true)
                {
                    player.GetComponent<PlayerMovement>().respawn();
                }
                else
                {
                    audioSource.PlayOneShot(hurtSound);
                    lose.loseLevel();
                }
                
                //player.GetComponent<PlayerMovement>().respawn();
                
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (hasBoxCollider)
        {
            // Get the BoxCollider2D component
            BoxCollider2D collider = GetComponent<BoxCollider2D>();

            // Draw a wireframe box with the same size as the BoxCollider2D
            Gizmos.color = Color.red;
            Vector2 position = new Vector2(transform.position.x, transform.position.y);
            Gizmos.DrawWireCube(position + collider.offset, collider.size);
        }
    }
}
