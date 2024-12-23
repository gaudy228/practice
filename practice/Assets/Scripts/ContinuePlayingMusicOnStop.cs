using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuePlayingMusicOnStop : MonoBehaviour
{
    public static ContinuePlayingMusicOnStop sourceInstance;

    [SerializeField] private AudioSource musicSource;

    private void Start()
    {
        if (sourceInstance == null)
        {
            sourceInstance = this;
        }
        musicSource.Play();
        
    }
    public void TimeOnStop(float stopTime)
    {
        musicSource.time = stopTime;
        Debug.Log(musicSource.time);
    }
}