using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    [SerializeField] private ManagerEnemySlot managerEnemySlot;
    [SerializeField] private ManagerTestTube managerTestTube;

    [Header("Audio")]
    [SerializeField] private Slider masterAudioSlider;
    [SerializeField] private Slider musicAudioSlider;
    [SerializeField] private Slider SFXAudioSlider;
    private void Start()
    {
        masterAudioSlider.value = PlayerPrefs.GetFloat("MasterSlider");
        musicAudioSlider.value = PlayerPrefs.GetFloat("MusicSlider");
        SFXAudioSlider.value = PlayerPrefs.GetFloat("SoundFXSlider");
    }
    public void SaveData()
    {
        PlayerPrefs.SetInt("MES", managerEnemySlot.maxRangeSpawnTestTube);
        PlayerPrefs.SetInt("MPS", managerTestTube.maxRangeSpawnTestTube);
    }

    public void SaveAudioSlidersValue()
    {
        
        PlayerPrefs.SetFloat("MasterSlider", masterAudioSlider.value);
        PlayerPrefs.SetFloat("MusicSlider", musicAudioSlider.value);
        PlayerPrefs.SetFloat("SoundFXSlider", SFXAudioSlider.value);
        
    }
}
