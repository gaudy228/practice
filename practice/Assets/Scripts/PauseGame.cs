using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button unPauseButton;

    [SerializeField] private Image pausePanel;

    private bool isPaused = false;

    private void Start()
    {
        pauseButton.onClick.AddListener(Pause);
        unPauseButton.onClick.AddListener(UnPause);
    }

    private void Update()
    {
        EscapePressed();
    }

    private void EscapePressed()
    {
        if (isPaused && Input.GetKeyDown(KeyCode.Escape))
        {
            UnPause();
        }
        else if (!isPaused && Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    private void Pause()
    {
        pausePanel.gameObject.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }
    private void UnPause()
    {
        pausePanel.gameObject.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }
}
