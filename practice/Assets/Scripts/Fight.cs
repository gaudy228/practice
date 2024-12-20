using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField] private GameObject mainSlot;
    [SerializeField] private GameObject mainEnemySlot;
    private ManagerEnemySlot managerEnemySlot;
    private Player player;
    private Enemy enemy;

    public int idPlayer;
    public int idEnemy;

    public int damagePlayer;
    public int damageEnemy;

    private void Start()
    {
       
        managerEnemySlot = GetComponent<ManagerEnemySlot>();
        player = GetComponent<Player>();
        enemy = GetComponent<Enemy>();
    }

    public void GoPlayFight()
    {
        int rnd = Random.Range(0, 3);
        foreach (Transform child in managerEnemySlot.EnemySlot[rnd].transform)
        {
            ClearChildren();
            Instantiate(child.gameObject, mainEnemySlot.transform);
            idEnemy = child.gameObject.GetComponent<Tube>().id;
            damageEnemy = child.gameObject.GetComponent<Tube>().damage;
        }
        foreach (Transform child in mainSlot.transform)
        {
            idPlayer = child.gameObject.GetComponent<Tube>().id;
            damagePlayer = child.gameObject.GetComponent<Tube>().damage;
        }




        if (idPlayer == 1 && idEnemy == 2 ||
            idPlayer == 1 && idEnemy == 4 ||
            idPlayer == 2 && idEnemy == 3 ||
            idPlayer == 2 && idEnemy == 4 ||
            idPlayer == 3 && idEnemy == 4 ||
            idPlayer == 3 && idEnemy == 5 ||
            idPlayer == 4 && idEnemy == 3 ||
            idPlayer == 4 && idEnemy == 3 ||
            idPlayer == 5 && idEnemy == 3 ||
            idPlayer == 5 && idEnemy == 4 ||
            idPlayer == 6 && idEnemy == 2 ||
            idPlayer == 6 && idEnemy == 5)
        {
            enemy.TakeDamage(damagePlayer);
        }
        else if(idEnemy == 1 && idPlayer == 3 ||
                idEnemy == 1 && idPlayer == 6 ||
                idEnemy == 2 && idPlayer == 2 ||
                idEnemy == 2 && idPlayer == 5 ||
                idEnemy == 3 && idPlayer == 1 ||
                idEnemy == 3 && idPlayer == 2 ||
                idEnemy == 4 && idPlayer == 1 ||
                idEnemy == 4 && idPlayer == 2 ||
                idEnemy == 5 && idPlayer == 3 ||
                idEnemy == 5 && idPlayer == 4 ||
                idEnemy == 6 && idPlayer == 2 ||
                idEnemy == 6 && idPlayer == 5)
        {
            player.TakeDamage(damageEnemy);
        }
        else
        {
            Debug.Log("0");
        }

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
}
