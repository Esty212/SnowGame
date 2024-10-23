using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class IceCubeMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbCube;

    public void Blow(float blowPower)
    {
        rbCube.AddForce(blowPower * Vector2.right, ForceMode2D.Impulse);
    }
}
