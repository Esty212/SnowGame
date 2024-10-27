using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlowableObject : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBodyRef;

    public void Blow(float blowPower)
    {
        rigidBodyRef.bodyType = RigidbodyType2D.Dynamic;
        rigidBodyRef.AddForce(blowPower * Vector2.right, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            rigidBodyRef.bodyType = RigidbodyType2D.Static;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            rigidBodyRef.bodyType = RigidbodyType2D.Dynamic;
    }
}
