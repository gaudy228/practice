using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField] private GameObject mainSlot;
    [SerializeField] private GameObject mainEnemySlot;
    private ManagerEnemySlot managerEnemySlot;
    private Player player;
    private Enemy enemy;

    private int idPlayer;
    private int idEnemy;

    private int damagePlayer;
    private int damageEnemy;
    private int rnd;

    [HideInInspector] public int countTestTubeEnemy = 0;
    [SerializeField] private TextMeshProUGUI countTestTubeEnemyText;

    [SerializeField] private AudioClip drawClip;

    [SerializeField] private Consumables consumables;
    [SerializeField] private GameObject[] RedFrame;
    private void Start()
    {
       
        managerEnemySlot = GetComponent<ManagerEnemySlot>();
        player = GetComponent<Player>();
        enemy = GetComponent<Enemy>();
        RandomSlot();
    }
    private void Update()
    {
        countTestTubeEnemyText.text = countTestTubeEnemy.ToString();
        if (consumables.prediction)
        {
            RedFrame[rnd].SetActive(true);
            consumables.prediction = false;
        }
    }
    public void GoPlayFight()
    {
        ClearChildren();
        for (int i = 0; i < RedFrame.Length; i++)
        {
            RedFrame[i].SetActive(false);
        }
        foreach (Transform child in managerEnemySlot.EnemySlot[rnd].transform)
        {
            
            Instantiate(child.gameObject, mainEnemySlot.transform);
            idEnemy = child.gameObject.GetComponent<Tube>().id;
            damageEnemy = child.gameObject.GetComponent<Tube>().damage;
            DestroyImmediate(child.gameObject);
            if(countTestTubeEnemy > 0)
            {
                managerEnemySlot.ReRool();
                countTestTubeEnemy--;
                countTestTubeEnemyText.text = countTestTubeEnemy.ToString();
            }
            
        }
        foreach (Transform child in mainSlot.transform)
        {
            idPlayer = child.gameObject.GetComponent<Tube>().id;
            damagePlayer = child.gameObject.GetComponent<Tube>().damage;
        }




        if (idPlayer == 1 && idEnemy == 3 ||
            idPlayer == 1 && idEnemy == 5 ||
            idPlayer == 2 && idEnemy == 1 ||
            idPlayer == 2 && idEnemy == 6 ||
            idPlayer == 2 && idEnemy == 5 ||
            idPlayer == 3 && idEnemy == 4 ||
            idPlayer == 3 && idEnemy == 6 ||
            idPlayer == 3 && idEnemy == 2 ||
            idPlayer == 4 && idEnemy == 2 ||
            idPlayer == 4 && idEnemy == 1 ||
            idPlayer == 5 && idEnemy == 3 ||
            idPlayer == 5 && idEnemy == 4 ||
            idPlayer == 6 && idEnemy == 5 ||
            idPlayer == 6 && idEnemy == 4)
        {
            if (consumables.dobleDamage)
            {
                
                enemy.TakeDamage(damagePlayer);
                consumables.dobleDamage = false;
            }
            enemy.TakeDamage(damagePlayer);
            
            Zeroing();
        }
        else if (idEnemy == 1 && idPlayer == 3 ||
                 idEnemy == 1 && idPlayer == 5 ||
                 idEnemy == 2 && idPlayer == 1 ||
                 idEnemy == 2 && idPlayer == 6 ||
                 idEnemy == 2 && idPlayer == 5 ||
                 idEnemy == 3 && idPlayer == 4 ||
                 idEnemy == 3 && idPlayer == 6 ||
                 idEnemy == 3 && idPlayer == 2 ||
                 idEnemy == 4 && idPlayer == 2 ||
                 idEnemy == 4 && idPlayer == 1 ||
                 idEnemy == 5 && idPlayer == 3 ||
                 idEnemy == 5 && idPlayer == 4 ||
                 idEnemy == 6 && idPlayer == 5 ||
                 idEnemy == 6 && idPlayer == 4)
        {
            if (consumables.dobleDamage)
            {
                player.TakeDamage(damageEnemy);
                consumables.dobleDamage = false;
            }
            player.TakeDamage(damageEnemy);
            Zeroing();
        }
        else if (idEnemy == 0)
        {
            if (consumables.dobleDamage)
            {
                enemy.TakeDamage(damagePlayer);
                consumables.dobleDamage = false;
            }
            enemy.TakeDamage(damagePlayer);
            
            Zeroing();
        }
        else
        {
            SoundFXManager.SFXinstance.PlaySoundFXClip(drawClip, transform, 0.1f);
            Zeroing();
        }
        RandomSlot();
    }
    private void Zeroing()
    {
        idPlayer = 0;
        idEnemy = 0;
        damageEnemy = 0;
        damagePlayer = 0;
    }
    private void ClearChildren()
    {

        int i = 0;


        GameObject[] allChildren = new GameObject[mainEnemySlot.transform.childCount];


        foreach (Transform child in mainEnemySlot.transform)
        {
            allChildren[i] = child.gameObject;
            i += 1;
        }


        foreach (GameObject child in allChildren)
        {
            DestroyImmediate(child.gameObject);
        }


    }
    private void RandomSlot()
    {
        bool[] isFull = new bool[3];
        int countChildren = 0;
        for (int i = 0; i < managerEnemySlot.EnemySlot.Length; i++)
        {
            if (managerEnemySlot.EnemySlot[i].transform.childCount == 1)
            {
                countChildren++;
                isFull[i] = true;
            }
        }
        if(countChildren == 3)
        {
            rnd = Random.Range(0, 3);
            return;
        }
        if (isFull[0] && isFull[1] && !isFull[2])
        {
            rnd = Random.Range(0, 2);
        }
        else if (!isFull[0] && isFull[1] && isFull[2])
        {
            rnd = Random.Range(1, 3);
        }
        else if (isFull[0] && !isFull[1] && isFull[2])
        {
            int rndm = Random.Range(1, 3);
            if (rndm == 1)
            {
                rnd = 0;
            }
            else
            {
                rnd = 2;
            }
        }
        else 
        {
            for(int i = 0; i < isFull.Length; i++)
            {
                if (isFull[i])
                {
                    rnd = i;
                }
            }
        }
    }
}
