using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : MonoBehaviour
{
    private BoxCollider2D _riverCollider;
    public SpriteRenderer spriteRenderer;
    public Sprite frozenRiver;


    private void Start()
    {
        _riverCollider = GetComponent<BoxCollider2D>();
    }

    public void Freeze()
    {
        _riverCollider.isTrigger = false;
        spriteRenderer.sprite = frozenRiver;
    }

}
