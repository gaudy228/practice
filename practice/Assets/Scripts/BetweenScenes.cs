
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetweenScenes : MonoBehaviour
{
    public void GoPlay()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.DeleteAll();
    }
    public void GoMainMemu()
    {
        SceneManager.LoadScene(0);
        
    }
}
