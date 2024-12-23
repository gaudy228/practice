
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager SFXinstance;

    [SerializeField] private AudioSource soundFXPlayer;

    private void Awake()
    {
        if (SFXinstance == null)
        {
            SFXinstance = this;
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

        audioSource.Play();

        //Get float value of how much time the clip is playing
        float clipLength = audioSource.clip.length;

        //Destroy GameObject once the clip has ended
        Destroy(audioSource.gameObject, clipLength);
    }


}
