using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField] private ManagerEnemySlot managerEnemySlot;
    [SerializeField] private ManagerTestTube managerTestTube;

    public void SaveData()
    {
        PlayerPrefs.SetInt("MES", managerEnemySlot.maxRangeSpawnTestTube);
        PlayerPrefs.SetInt("MPS", managerTestTube.maxRangeSpawnTestTube);
    }
}
