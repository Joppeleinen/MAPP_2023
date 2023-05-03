using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_archie_skin : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite9;
    // Sptart is called before the first frame update
    void Start()
    {
        if (ActiveItemHandler.activeUnlock1 == true)
        {
            spriteRenderer.sprite = sprite1;
        }
        if (ActiveItemHandler.activeUnlock2 == true)
        {
            spriteRenderer.sprite = sprite2;
        }
        if (ActiveItemHandler.activeUnlock4 == true)
        {
            spriteRenderer.sprite = sprite4;
        }
        if (ActiveItemHandler.activeUnlock5 == true)
        {
            spriteRenderer.sprite = sprite5;
        }
        if (ActiveItemHandler.activeUnlock6 == true)
        {
            spriteRenderer.sprite = sprite6;
        }
        if (ActiveItemHandler.activeUnlock7 == true)
        {
            spriteRenderer.sprite = sprite7;
        }
        if (ActiveItemHandler.activeUnlock9 == true)
        {
            spriteRenderer.sprite = sprite9;
        }
    }

}
