using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetAudioSlidersValue : MonoBehaviour
{
    [SerializeField] private Slider masterAudioSlider;
    [SerializeField] private Slider musicAudioSlider;
    [SerializeField] private Slider SFXAudioslider;



    private void Start()
    {
        masterAudioSlider.value = PlayerPrefs.GetFloat("MasterSlider");
        musicAudioSlider.value = PlayerPrefs.GetFloat("MusicSlider");
        SFXAudioslider.value = PlayerPrefs.GetFloat("SoundFXSlider");
    }
}
