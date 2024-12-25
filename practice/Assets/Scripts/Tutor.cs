using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutor : MonoBehaviour
{
    public int isTutor = 0;
    private int countText = 0;
    [SerializeField] private EngAndRu engAndRu;
    [SerializeField] private TextMeshProUGUI textTut;
    [SerializeField] private GameObject arrowInfo;
    [SerializeField] private GameObject arrowMyTube;
    [SerializeField] private GameObject arrowEnemyTube;
    [SerializeField] private GameObject arrowMainSlotAndButton;
    [SerializeField] private GameObject arrowCon;
    [SerializeField] private GameObject ConPred;
    [SerializeField] private GameObject ConDamage;
    [SerializeField] private GameObject ConHP;
    [SerializeField] private GameObject arrowCountTubeEnemy;
    [SerializeField] private GameObject arrowMainEnemySlot;
    [SerializeField] private GameObject PanelTutor;
    private bool optim = false;
    [SerializeField] private bool reallyTutor;
    private void Start()
    {
        if (reallyTutor)
        {
            isTutor = 1;
        }
        else
        {
            isTutor = 0;
        }
    }
    private void Update()
    {
        if(countText == 0 && !optim && reallyTutor)
        {
            if(engAndRu.isEng == 1)
            {
                textTut.text = "Welcome to the Toxic Clash game";
            }
            else
            {
                textTut.text = "ƒобро пожаловать в игру Toxic Clash";
            }
            
            optim = true;
        }
        else if(countText == 1 && optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "Here you will have to fight penguins, just like in the rock paper scissors game";
            }
            else
            {
                textTut.text = "«десь тебе придетс€ сражатьс€ с пингвинами, практически также как и в игре камень ножницы бумага";
            }
            
            optim = false;
        }
        else if(countText == 2 && !optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "Some tubes hit other tubes and damage is inflicted on the enemy or you";
            }
            else
            {
                textTut.text = "Ќекоторые пробирки бьют другие пробирки и противнику или тебе наноситс€ урон";
            }
            
            optim = true;
        }
        else if (countText == 3 && optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "Some self-destruct and no damage is done to anyone";
            }
            else
            {
                textTut.text = "Ќекоторые самоуничтожаютс€ и никому не наноситс€ урон";
            }
            
            optim = false;
        }
        else if (countText == 4 && !optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "All chains can be viewed here, even during combat";
            }
            else
            {
                textTut.text = "¬се цепочки можно посмотреть здесь, даже во врем€ бо€";
            }
            
            optim = true;
            arrowInfo.SetActive(true);
        }
        else if (countText == 5 && optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "All your available throwing tubes are displayed here";
            }
            else
            {
                textTut.text = "«десь отображаютс€ все твои доступные пробирки дл€ метание";
            }
            
            optim = false;
            arrowInfo.SetActive(false);
            arrowMyTube.SetActive(true);
        }
        else if (countText == 6 && !optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "All enemy tubes are displayed here";
            }
            else
            {
                textTut.text = "«десь отображаютс€ все вражеские пробирки";
            }
            
            optim = true;
            arrowMyTube.SetActive(false);
            arrowEnemyTube.SetActive(true);
        }
        else if (countText == 7 && optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "To throw a test tube at an enemy, drag it into the central slot and press the button";
            }
            else
            {
                textTut.text = "„тобы кинуть во врага пробирку перетащите ее в центральный слот и нажмите кнопку";
            }
            
            optim = false;
            arrowEnemyTube.SetActive(false);
            arrowMainSlotAndButton.SetActive(true);
        }
        else if (countText == 8 && !optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "You also have consumables";
            }
            else
            {
                textTut.text = "“акже у теб€ есть расходники";
            }
            
            optim = true;
            arrowMainSlotAndButton.SetActive(false);
            arrowCon.SetActive(true);
        }
        else if (countText == 9 && optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "Blue with an eye - predicts which test tube the opponent is using";
            }
            else
            {
                textTut.text = "—иний с глазом - предсказывает какую пробирку использует противник";
            }
            
            optim = false;

            ConPred.SetActive(true);
        }
        else if (countText == 10 && !optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "Green with a cross - restores 1 health";
            }
            else
            {
                textTut.text = "«еленый с крестиком - восстанавливает 1 здоровье";
            }
            
            optim = true;
            ConPred.SetActive(false);
            ConHP.SetActive(true);
        }
        else if (countText == 11 && optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "Red with a fist - increases the damage of the next tube by 2 times (both your own and the opponent's)";
            }
            else
            {
                textTut.text = " расное с кулаком - увеличивает урон следующей пробирки в 2 раза (как свой, так и противника)";
            }
            
            optim = false;
            ConHP.SetActive(false);
            ConDamage.SetActive(true);
        }
        else if (countText == 12 && !optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "The opponent also has a limited number of tubes, the number of tubes in stock is displayed here";
            }
            else
            {
                textTut.text = "“ак же у противника ограниченное количество пробирок, количество пробирок в запасе отображаетс€ здесь";
            }
            
            optim = true;
            arrowCon.SetActive(false);
            ConDamage.SetActive(false);
            arrowCountTubeEnemy.SetActive(true);
        }
        else if (countText == 13 && optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "The opponent's last throw is displayed here";
            }
            else
            {
                textTut.text = "«десь отображаетс€ прошлый бросок противника";
            }
            
            optim = false;
            arrowCountTubeEnemy.SetActive(false);
            arrowMainEnemySlot.SetActive(true);
        }
        else if (countText == 14 && !optim)
        {
            if (engAndRu.isEng == 1)
            {
                textTut.text = "Now, good luck";
            }
            else
            {
                textTut.text = "ј теперь удачи";
            }
            
            optim = true;
            arrowMainEnemySlot.SetActive(false);
            PanelTutor.SetActive(false);
        }
    }

    
    public void GoNextText()
    {
        countText++;
    }
}
