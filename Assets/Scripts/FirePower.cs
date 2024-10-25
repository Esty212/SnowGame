using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;

public class FirePower : MonoBehaviour
{
    [SerializeField] private float meltingTime;
    private GameObject _iceCube;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MeltableObject foundIceCube = collision.GetComponent<MeltableObject>();
        if (foundIceCube)
        {
            _iceCube = foundIceCube.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_iceCube && collision.gameObject == _iceCube)
            _iceCube = null;
    }

    public void DestroyIceCube()
    {
        if (_iceCube != null)
        {
            Destroy(_iceCube, meltingTime);
        }
    }


}
