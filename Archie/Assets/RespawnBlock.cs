using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBlock : MonoBehaviour
{
    public GameObject blockSpawn;
    public GameObject block;



    public void respawnFromCheckpoint()
    {
        block.transform.position = blockSpawn.transform.position;
    }

}
