using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class WindPower : MonoBehaviour
{
    private bool _inRange;
    private UnityEvent<float> windBlow;
    [SerializeField] private float blowPower;



    // Start is called before the first frame update
    void Start()
    {
        windBlow = new UnityEvent<float>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_inRange)
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
                windBlow.Invoke(Mathf.Sign(transform.localScale.x) * blowPower);
            }
        }
    }

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
}
