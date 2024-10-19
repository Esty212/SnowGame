using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class Carrots : MonoBehaviour
{
    private static UnityEvent OnCarrotCollected = new();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnCarrotCollected.Invoke();
            Destroy(gameObject);
        }
    }

    public static void AddOnCarrotCollectedEventListener(UnityAction newListener)
    {
        OnCarrotCollected.AddListener(newListener);
    }

}
