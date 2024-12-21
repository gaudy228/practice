using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private GameObject panelMap;
    [HideInInspector] public float currHealth;

    

    [SerializeField] private Image healthBar;

    [SerializeField] private TextMeshProUGUI showAmountOfHp;
    [SerializeField] private Map map;
    private int nextLocation;
    private ManagerEnemySlot managerEnemySlot;
    private ManagerTestTube managerTestTube;
    [SerializeField] private Save save;
    private void Awake()
    {
        nextLocation = PlayerPrefs.GetInt("nextLocation");
        
    }
    private void Start()
    {
        managerEnemySlot = GetComponent<ManagerEnemySlot>();
        managerTestTube = GetComponent<ManagerTestTube>();
        if(nextLocation == 0)
        {
            nextLocation++;
        }
        
        
        currHealth = maxHealth;
        showAmountOfHp.text = $"{currHealth} / {maxHealth}";
    }


    public void TakeDamage(int damage)
    {
        currHealth -= damage;
        if(currHealth <= 0 && map.lastFight)
        {
            map.lastFight = false;
            nextLocation++;
            managerEnemySlot.maxRangeSpawnTestTube++;
            managerTestTube.maxRangeSpawnTestTube++;
            save.SaveData();
            PlayerPrefs.SetInt("nextLocation", nextLocation);
            PlayerPrefs.Save();
            SceneManager.LoadScene(nextLocation);
        }
        else if (currHealth <= 0)
        {
            panelMap.SetActive(true);
            Time.timeScale = 0f;
            maxHealth ++;
            currHealth = maxHealth;
        }

        

        healthBar.fillAmount = currHealth / maxHealth;

        showAmountOfHp.text = $"{currHealth} / {maxHealth}";
    }
}
