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

    [SerializeField] private AudioClip locationChosenClip;
    private void Start()
    {
        
        ReButton();
    }
    
    public void EnemyChoice()
    {
        countWin++;
        ReButton();
        
        maxCountTubeEnemy++;
        fight.countTestTubeEnemy = maxCountTubeEnemy;
        managerEnemySlot.ReRool();
        SoundFXManager.SFXinstance.PlaySoundFXClip(locationChosenClip, transform, 0.1f);
        Time.timeScale = 1;
        gameObject.SetActive(false);
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
