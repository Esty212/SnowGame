using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMan : PlayableCharacter
{
    [SerializeField] IcePower icePower;

    protected override void SpecialAbility()
    {
        icePower.OnFreeze();
    }
}
