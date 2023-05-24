using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAttachedToCheckpoint : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }
    private void OnDrawGizmos()
    {

        // Get the BoxCollider2D component
        BoxCollider2D collider = GetComponent<BoxCollider2D>();

        // Draw a wireframe box with the same size as the BoxCollider2D
        Gizmos.color = Color.gray;
        Vector2 position = new Vector2(transform.position.x, transform.position.y);
        Gizmos.DrawWireCube(position + collider.offset, collider.size);

    }
}
