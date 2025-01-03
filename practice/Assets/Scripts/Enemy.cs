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

    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip takeDamageClip;
    [SerializeField] private AudioClip enemyDefeatedClip;

    [SerializeField] private Consumables consumables;
    [SerializeField] private Tutor tutor;
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
        else if (currHealth <= 0 && tutor.isTutor == 0)
        {
            panelMap.SetActive(true);
            Time.timeScale = 0f;
            maxHealth++;
            currHealth = maxHealth;
            SoundFXManager.SFXinstance.PlaySoundFXClip(enemyDefeatedClip, transform, 0.1f);
            consumables.ReRool();
        }
        else if(currHealth <= 0 && tutor.isTutor == 1)
        {
            SceneManager.LoadScene(0);
        }
        SoundFXManager.SFXinstance.PlaySoundFXClip(takeDamageClip, transform, 0.1f);


        healthBar.fillAmount = currHealth / maxHealth;

        showAmountOfHp.text = $"{currHealth} / {maxHealth}";
    }
}
