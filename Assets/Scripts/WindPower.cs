using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class WindPower : MonoBehaviour
{
    private bool _inRange;
    private UnityEvent<float> windBlow = new UnityEvent<float>();
    [SerializeField] private float blowPower;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _inRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _inRange = false;
    }

    public void AddWindBlowEventListener(UnityAction<float> newListener)
    {
        windBlow.AddListener(newListener);
    }

    public void OnBlow()
    {
        if (_inRange)
            windBlow.Invoke(Mathf.Sign(transform.localScale.x) * blowPower);  
    }
}
