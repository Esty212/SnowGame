using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    int damageFromSpike = 0;

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(true);
        damageFromSpike += 2;
        Debug.Log("Player Damaged!");

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
    }

}
