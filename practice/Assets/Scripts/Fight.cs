using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    private ManagerTestTube managerTestTube;
    private ManagerEnemySlot managerEnemySlot;

    public GameObject d;

    private void Start()
    {
        managerTestTube = GetComponent<ManagerTestTube>();
        managerEnemySlot = GetComponent<ManagerEnemySlot>();
    }

    public void GoPlayFight()
    {
        int rnd = Random.Range(0, 3);
        foreach (Transform child in managerEnemySlot.EnemySlot[rnd].transform)
        {
            d = child.gameObject;
        }
    }
}
