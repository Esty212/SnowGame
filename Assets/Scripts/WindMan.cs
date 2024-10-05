using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMan : PlayableCharacter
{
    [SerializeField] WindPower windPower;

    protected override void SpecialAbility()
    {
        windPower.OnBlow();
    }


}
