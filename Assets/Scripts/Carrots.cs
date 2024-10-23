using UnityEngine;
using UnityEngine.Events;

public class Carrots : MonoBehaviour
{
    private static UnityEvent OnCarrotCollected = new();
    private bool _wasCollected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_wasCollected && collision.CompareTag("Player"))
        {
            _wasCollected = true;
            OnCarrotCollected.Invoke();
            Destroy(gameObject);
        }
    }

    public static void AddOnCarrotCollectedEventListener(UnityAction newListener)
    {
        OnCarrotCollected.AddListener(newListener);
    }

}
