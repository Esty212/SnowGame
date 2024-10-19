using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    private static UnityEvent<Vector3> FallDown = new();


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FallDown.Invoke(respawnPoint.position);
        }
    }

    public static void AddFallFromRiverListener(UnityAction<Vector3> newlistener)
    {
        FallDown.AddListener(newlistener);
    }


}
