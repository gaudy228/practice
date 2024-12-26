using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EngAndRuGameOver : MonoBehaviour
{
    private int isEng;
    [SerializeField] private TextMeshProUGUI gameOver;
    [SerializeField] private TextMeshProUGUI buttonRePlay;
    [SerializeField] private TextMeshProUGUI buttonGoMenu;
    private bool optim = true;
    private void Start()
    {
        isEng = PlayerPrefs.GetInt("Eng");
    }
    private void Update()
    {
        if (optim)
        {
            if (isEng == 1)
            {
                gameOver.text = "You lose";
                buttonRePlay.text = "Again";
                buttonGoMenu.text = "Back to menu";
            }
            else
            {
                gameOver.text = "Ты проиграл";
                buttonRePlay.text = "Заново";
                buttonGoMenu.text = "Главное меню";
            }
            optim = false;
        }

    }
}
