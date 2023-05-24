using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingEnemy : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    //[SerializeField] private float damage;

    /*[Header("Saw Sound")]
    [SerializeField] private AudioClip sawSound;*/

    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;

    private void Awake()
    {
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
    }

    private void Update()
    {
        if (movingLeft)
        {
            if (transform.position.x > leftEdge)
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
                rotationSpeed = -Mathf.Abs(rotationSpeed);
            }
            else
                movingLeft = false;
        }
        else
        {
            if (transform.position.x < rightEdge)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
                rotationSpeed = Mathf.Abs(rotationSpeed);
            }
            else
                movingLeft = true;
        }

        transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.instance.PlaySound(sawSound);
            collision.GetComponent<Health>().TakeDamage(damage);
        }

    }*/
}
