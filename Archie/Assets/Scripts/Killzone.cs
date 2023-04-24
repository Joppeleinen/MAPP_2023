using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{

    public bool hasBoxCollider;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {

                player.GetComponent<PlayerMovement>().respawn();
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
