
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Image pausePanel;
    [SerializeField] private GameObject buttonPause;
    private bool isPaused = false;

    [SerializeField] private AudioClip pauseClip;
    [SerializeField] private AudioClip unPauseClip;
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
    public void Pause()
    {
        pausePanel.gameObject.SetActive(true);
        buttonPause.gameObject.SetActive(false);
        isPaused = true;
        SoundFXManager.SFXinstance.PlaySoundFXClip(pauseClip, transform, 0.1f);
        Time.timeScale = 0f;
    }
    public void UnPause()
    {
        pausePanel.gameObject.SetActive(false);
        buttonPause.gameObject.SetActive(true);
        isPaused = false;
        SoundFXManager.SFXinstance.PlaySoundFXClip(unPauseClip, transform, 0.1f);
        Time.timeScale = 1f;
    }
}
