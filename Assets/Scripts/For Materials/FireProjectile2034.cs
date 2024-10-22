using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// if i press the button -> perform a shoot function that will produce the projectile
//at the wanted location
public class FireProjectile2034 : MonoBehaviour
{
    public Transform fireProjectilePoint; // WeaponPoint/weaponProjectilePoint
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, fireProjectilePoint.position, fireProjectilePoint.rotation); // create a copy of something at the specific position
    }
}
