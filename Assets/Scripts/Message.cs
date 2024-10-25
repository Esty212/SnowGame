using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour
{
    [SerializeField] private GameObject MessageObject;
    private bool isInCollision;

    private void Awake()
    {
        MessageObject.SetActive(false);
    }

    private void Start()
    {
        isInCollision = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && isInCollision == false)
        {
            MessageObject.SetActive(true);
            isInCollision = true;
        }
        else
            isInCollision = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInCollision = false;
        MessageObject.SetActive(false);
    }

}
