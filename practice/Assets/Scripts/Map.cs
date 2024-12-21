using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    private int countWin = 0;
   
    [SerializeField] private Button[] buttonEnemy;
    [SerializeField] private ManagerEnemySlot managerEnemySlot;
    [SerializeField] private Fight fight;
    private int maxCountTubeEnemy = -1;
    [HideInInspector] public bool lastFight = false;
    private void Start()
    {
        
        ReButton();
    }
    
    public void EnemyChoice()
    {
        countWin++;
        ReButton();
        gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        maxCountTubeEnemy++;
        fight.countTestTubeEnemy = maxCountTubeEnemy;
        managerEnemySlot.ReRool();
        
    }
    public void EnemyFinalChoice()
    {
        lastFight = true;
    }
    private void ReButton()
    {
        for (int i = 0; i < buttonEnemy.Length; i++)
        {
            if (i == countWin)
            {
                buttonEnemy[i].interactable = true;
            }
            else
            {
                buttonEnemy[i].interactable = false;
                if(i < countWin)
                {
                    foreach (Transform child in buttonEnemy[i].transform)
                    {
                        child.gameObject.SetActive(true);
                    }
                }
            }
        }
    }
}
