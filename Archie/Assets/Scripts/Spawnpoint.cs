using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public GameObject spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnpoint.GetComponent<SpriteRenderer>().enabled = false;
    }

}
