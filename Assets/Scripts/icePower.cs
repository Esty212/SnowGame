using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IcePower : MonoBehaviour
{
    private River _river;

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
        if (_river && collision.gameObject == _river.gameObject)
        {
            _river = null;
        }

    }

    public void OnFreeze()
    {
        if (_river != null)
        {
            _river.Freeze();
        }
    }
}
