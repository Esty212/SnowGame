using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;

public class FirePower : MonoBehaviour
{
    private GameObject iceCube;

    private void Update()
    {
        if (iceCube != null && Input.GetKeyDown(KeyCode.X))
        {
            DestroyIceCube();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IceCubeMovement foundIceCube = collision.GetComponent<IceCubeMovement>();
        if (foundIceCube != null)
        {
            iceCube = foundIceCube.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        iceCube = null;
    }

    void DestroyIceCube()
    {
        if (iceCube != null)
        {
            Destroy(iceCube, 1);
        }
    }


}
