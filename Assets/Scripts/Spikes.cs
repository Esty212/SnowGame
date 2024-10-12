using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Spikes : MonoBehaviour
{
    [SerializeField] int damageFromSpike = 0;

    private static UnityEvent<int> _onTakeDamage = new UnityEvent<int>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _onTakeDamage.Invoke(damageFromSpike);
            damageFromSpike++;
            Debug.Log("Damaged");

        }
    }

    public static void AddOnTakeDamageEventListener(UnityAction<int> newListener)
    {
        _onTakeDamage.AddListener(newListener);
    }

}
