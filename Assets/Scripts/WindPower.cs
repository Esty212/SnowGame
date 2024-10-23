using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class WindPower : MonoBehaviour
{
    [SerializeField] private float blowPower;
    private BlowableObject _objectToBlow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*IceCubeMovement potentialObject = collision.GetComponent<IceCubeMovement>();
        if (potentialObject)
        {
            _objectToBlow = potentialObject;
        }*/
        BlowableObject potentialObject = collision.GetComponent<BlowableObject>();
        if (potentialObject)
        {
            _objectToBlow = potentialObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_objectToBlow && collision.gameObject == _objectToBlow.gameObject)
        {
            _objectToBlow = null;
        }
    }

    public void OnBlow()
    {
        if (_objectToBlow)
            _objectToBlow.Blow(Mathf.Sign(transform.localScale.x) * blowPower);  
    }
}
