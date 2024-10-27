using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class MeltableObject : MonoBehaviour
{
    [SerializeField] private float meltingTime;
    [SerializeField] private GameObject particleContainer;

    private void Start()
    {
        if (particleContainer)
            particleContainer.SetActive(false);
    }

    public void Burn()
    {
        if (particleContainer)
            particleContainer.SetActive(true);
        Destroy(gameObject, meltingTime);
    }


}
