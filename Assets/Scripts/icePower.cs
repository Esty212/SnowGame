using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class icePower : MonoBehaviour
{
    private River _river;

    private void Update()
    {
        if (_river != null && Input.GetKey(KeyCode.X))
        {
            _river.Freeze();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        River foundRiver = collision.GetComponent<River>();
        if (foundRiver != null)
        {
            _river = foundRiver;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _river = null;
    }
}
