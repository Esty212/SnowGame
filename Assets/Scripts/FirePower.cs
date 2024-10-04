using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;

public class FirePower : MonoBehaviour
{
    private GameObject _iceCube;

    private void Update()
    {
        if (_iceCube != null && Input.GetKeyDown(KeyCode.X))
        {
            DestroyIceCube();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IceCubeMovement foundIceCube = collision.GetComponent<IceCubeMovement>();
        if (foundIceCube != null)
        {
            _iceCube = foundIceCube.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _iceCube = null;
    }

    void DestroyIceCube()
    {
        if (_iceCube != null)
        {
            Destroy(_iceCube, 1);
        }
    }


}
