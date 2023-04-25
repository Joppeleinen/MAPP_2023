using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            collision.GetComponent<PlayerMovement>().ChangeRespawnPosition(gameObject);

        }
    }

    private void OnDrawGizmos()
    {
        
            // Get the BoxCollider2D component
            BoxCollider2D collider = GetComponent<BoxCollider2D>();

            // Draw a wireframe box with the same size as the BoxCollider2D
            Gizmos.color = Color.green;
            Vector2 position = new Vector2(transform.position.x, transform.position.y);
            Gizmos.DrawWireCube(position + collider.offset, collider.size);
        
    }

}
