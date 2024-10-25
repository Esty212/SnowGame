using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMan : PlayableCharacter
{
    [SerializeField] FirePower firePower;

    protected override void SpecialAbility()
    {
        firePower.DestroyIceCube();
        firePower.ApplyDamageToEnemy();
    }


}
