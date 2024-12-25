using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetAudioSlidersValue : MonoBehaviour
{
    [SerializeField] private Slider masterAudioSlider;
    [SerializeField] private Slider musicAudioSlider;
    [SerializeField] private Slider SFXAudioSlider;



    private void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("MasterSlider"));
        Debug.Log(PlayerPrefs.GetFloat("MusicSlider"));
        Debug.Log(PlayerPrefs.GetFloat("SoundFXSlider"));
        masterAudioSlider.value = PlayerPrefs.GetFloat("MasterSlider");
        musicAudioSlider.value = PlayerPrefs.GetFloat("MusicSlider");
        SFXAudioSlider.value = PlayerPrefs.GetFloat("SoundFXSlider");
    }
}
