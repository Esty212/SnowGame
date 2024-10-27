using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.Events;

public class FirePower : MonoBehaviour
{
    [SerializeField] private float meltingTime;
    private MeltableObject _meltableObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MeltableObject foundMeltableObject = collision.GetComponent<MeltableObject>();
        if (foundMeltableObject)
        {
            _meltableObject = foundMeltableObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_meltableObject && collision.gameObject == _meltableObject)
            _meltableObject = null;
    }

    public void DestroyIceCube()
    {
        if (_meltableObject != null)
        {
            _meltableObject.Burn();
        }
    }


}
