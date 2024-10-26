using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Spikes : MonoBehaviour
{
    [SerializeField] private int damageFromSpike = 1;
    [SerializeField] private Vector2 knockBackForce;

    private static UnityEvent<int, Vector2> OnTakeDamage = new UnityEvent<int, Vector2>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnTakeDamage.Invoke(damageFromSpike, knockBackForce);

        }
    }

    public static void AddOnTakeDamageEventListener(UnityAction<int, Vector2> newListener)
    {
        OnTakeDamage.AddListener(newListener);
    }

}
