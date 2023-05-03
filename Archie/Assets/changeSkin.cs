using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkin : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite10;
    public Sprite sprite8;
    public Sprite sprite3;
    // Sptart is called before the first frame update
    void Start()
    {
        if(ActiveItemHandler.activeUnlock10 == true)
        {
            spriteRenderer.sprite = sprite10;
        }
        if (ActiveItemHandler.activeUnlock8 == true)
        {
            spriteRenderer.sprite = sprite8;
        }
        if (ActiveItemHandler.activeUnlock3 == true)
        {
            spriteRenderer.sprite = sprite3;
        }
    }

}
