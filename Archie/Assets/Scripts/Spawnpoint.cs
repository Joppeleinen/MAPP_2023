using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    
    public SpriteRenderer SR;
    public Vector2 vector2;

    // Start is called before the first frame update
    void Start()
    {
        //spawnpoint.GetComponent<SpriteRenderer>().enabled = false;
        vector2 = transform.position;
        SR.enabled = false; 
    }

}
