using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPlaySound : MonoBehaviour
{
    [SerializeField] private AudioClip pressButtonClip;

    public void PlaySound()
    {
        SoundFXManager.SFXinstance.PlaySoundFXClip(pressButtonClip, transform, 0.1f);
    }    
}
