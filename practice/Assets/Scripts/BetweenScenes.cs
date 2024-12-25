
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetweenScenes : MonoBehaviour
{
    public void GoPlay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        PlayerPrefs.DeleteKey("nextLocation");
        PlayerPrefs.DeleteKey("MES");
        PlayerPrefs.DeleteKey("MPS");
        
    }
    public void GoTutor()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
    }
    public void GoMainMemu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        
    }
}
