using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EngAndRu : MonoBehaviour
{
    [SerializeField] private bool inMenu;
    public int isEng;
    [SerializeField] private TextMeshProUGUI SettingsMain;
    [SerializeField] private TextMeshProUGUI SettingsMusic;
    [SerializeField] private TextMeshProUGUI SettingsVFX;
    [SerializeField] private TextMeshProUGUI goMenu;
    [SerializeField] private TextMeshProUGUI play;
    [SerializeField] private TextMeshProUGUI settings;
    [SerializeField] private TextMeshProUGUI tutor;
    private bool optim = true;
    private void Start()
    {
        isEng = PlayerPrefs.GetInt("Eng");
    }
    public void Eng()
    {
        isEng = 1;
        PlayerPrefs.SetInt("Eng", isEng);
        optim = true;
    }
    public void Ru()
    {
        isEng = 0;
        PlayerPrefs.SetInt("Eng", isEng);
        optim = true;
    }
    private void Update()
    {
        if (optim)
        {
            if (isEng == 1)
            {
                SettingsMain.text = "Main Volume";
                SettingsMusic.text = "Music";
                SettingsVFX.text = "Sounds";
                goMenu.text = "Back to menu";
                if (inMenu)
                {
                    play.text = "Play";
                    settings.text = "Settings";
                    tutor.text = "Tutorial";
                }
            }
            else
            {
                SettingsMain.text = "Общая громкость";
                SettingsMusic.text = "Mузыка";
                SettingsVFX.text = "Звуки";
                goMenu.text = "Назад в меню";
                if (inMenu)
                {
                    play.text = "Играть";
                    settings.text = "Настройки";
                    tutor.text = "Обучение";
                }
            }
            optim = false;
        }
        
    }
}
