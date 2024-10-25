using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;

public class FirePower : MonoBehaviour
{
    [SerializeField] private float meltingTime;
    [SerializeField] private int damageAmount = 1;
    private GameObject _iceCube;
    Monster _enemy;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        MeltableObject foundIceCube = collision.GetComponent<MeltableObject>();
        if (foundIceCube != null)
        {
            _iceCube = foundIceCube.gameObject;
        }

        Monster foundMonster = collision.GetComponent<Monster>();
        if (foundMonster != null)
        {
            _enemy = foundMonster;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        _iceCube = null;
        _enemy = null;

    }


    public void DestroyIceCube()
    {
        if (_iceCube != null)
        {
            Destroy(_iceCube, meltingTime);
        }
    }

    public void ApplyDamageToEnemy()
    {
        if (_enemy != null)
        {
            _enemy.TakeDamage(damageAmount);

        }
    }

}
