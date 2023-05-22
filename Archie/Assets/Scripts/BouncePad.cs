using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BouncePad : MonoBehaviour
{
    public float bounce = 100f;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip jumpPadSound;
    private bool sendBounce = false;
    public bool specialBounce = false;
    //Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        //Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Anim.SetBool("SendBounce", sendBounce);
        if (sendBounce)
        {
            sendBounce = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (specialBounce == false)
        {
            if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box") && sendBounce == false)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
                
                audioSource.PlayOneShot(jumpPadSound);
                sendBounce = true;

            }
        }

    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sendBounce = true;
    }
}

