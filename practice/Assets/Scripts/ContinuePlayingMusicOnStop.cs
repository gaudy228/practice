using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuePlayingMusicOnStop : MonoBehaviour
{
    public static ContinuePlayingMusicOnStop sourceInstance;

    [SerializeField] private AudioSource musicSource;
    private float timeOnStop;
    private void Start()
    {
        if (sourceInstance == null)
        {
            sourceInstance = this;
        }
        musicSource.time = timeOnStop;
        musicSource.Play();
        
    }
    public void TimeOnStop(float stopTime)
    {
        timeOnStop = stopTime;
        Debug.Log(musicSource.time);
    }
}