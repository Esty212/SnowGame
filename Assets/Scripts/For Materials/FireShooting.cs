using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShooting : MonoBehaviour
{
    private bool shooting;

    [SerializeField] private GameObject fireShooting;

    private void Start()
    {
            if(fireShooting == null )
            {
            fireShooting = transform.GetChild(0).gameObject;
            }    
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !shooting)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        fireShooting.GetComponent<FireProjectile>().Shoot();
        fireShooting.transform.parent = null;
        shooting = true;
    }    
}
