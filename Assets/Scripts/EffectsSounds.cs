using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsSounds : MonoBehaviour
{
    public static AudioClip iceShootSound, fireShootSound, windShootSound;
    static AudioSource audioSrc;
    void Start()
    {
        iceShootSound = Resources.Load<AudioClip>("iceShoot");
        fireShootSound = Resources.Load<AudioClip>("fireShoot");
        windShootSound = Resources.Load<AudioClip>("windShoot");

        audioSrc = GetComponent<AudioSource> ();

    }

    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        swtich (clip) 
        {
            case "iceShoot";
                audioSrc.PlayOneShot (iceShootSound);

        }
    }
}
