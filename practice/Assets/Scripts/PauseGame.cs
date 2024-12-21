
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Image pausePanel;
    [SerializeField] private GameObject buttonPause;
    private bool isPaused = false;
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
        Time.timeScale = 0f;
    }
    public void UnPause()
    {
        pausePanel.gameObject.SetActive(false);
        buttonPause.gameObject.SetActive(true);
        isPaused = false;
        Time.timeScale = 1f;
    }
}
