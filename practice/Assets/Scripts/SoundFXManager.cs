using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager instance;

    [SerializeField] private AudioSource soundFXPlayer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySoundFXClip(AudioClip audioClip, Transform spawnedGoTransform, float volume)
    {
        //Spawn in audioclip's player
        AudioSource audioSource = Instantiate(soundFXPlayer, spawnedGoTransform.position, Quaternion.identity);

        //Assign the audioClip
        audioSource.clip = audioClip;

        //Assign the volume
        audioSource.volume = volume;

        //Get float value of how much time the clip is playing
        float clipLength = audioSource.clip.length;

        //Destroy GameObject once the clip has ended
        Destroy(audioSource.gameObject, clipLength);
    }


}
