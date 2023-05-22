using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBlock : MonoBehaviour
{
    public GameObject blockSpawn;
    private Vector2 vector2;
    public GameObject block;
    private GameObject loseMenu;
    private GameObject loseMenuScript;

    public void Start()
    {
        loseMenu = GameObject.Find("FindsLoseMenu");
        loseMenuScript = loseMenu.GetComponent<FindsLoseMenu>().getLoseMenu();
        loseMenuScript.GetComponent<LoseMenu>().addBox(gameObject);
        vector2 = gameObject.transform.position;
        


    }
    public void respawnFromCheckpoint()
    {
        block.transform.position = vector2;
    }

}
