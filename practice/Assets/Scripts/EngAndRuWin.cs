using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EngAndRuWin : MonoBehaviour
{
    private int isEng;
    [SerializeField] private TextMeshProUGUI finalText;
    [SerializeField] private TextMeshProUGUI buttonText;
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
                buttonText.text = "Main menu";
                finalText.text = "You defeated all the penguins, and became the king of penguins in the land of penguins, and became the best alchemist among penguins, and all penguins respect and love you, and penguins love you, and you married a penguin, and you became the king of life and penguins";
            }
            else
            {
                finalText.text = "Ты победил всех пингвинов, и стал королем пингвинов в стране пингвинов, и стал лучшим алхимиком среди пингвинов и все пингвины тебя уважают и любят пингвины тебя, а также ты женился на пингвинихе и ты стал королем жизни и пингвинов";
                buttonText.text = "Главное меню";
            }
            optim = false;
        }
        
    }
}
