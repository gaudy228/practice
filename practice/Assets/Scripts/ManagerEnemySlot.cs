using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ManagerEnemySlot : MonoBehaviour
{
    public GameObject[] EnemySlot;
    public GameObject testTube;
    private TubeSO[] tubeSOs;

    [HideInInspector] public int maxRangeSpawnTestTube;
    private void Awake()
    {
        maxRangeSpawnTestTube = PlayerPrefs.GetInt("MES");
        
    }
    private void Start()
    {
        if (maxRangeSpawnTestTube == 0)
        {
            maxRangeSpawnTestTube = 3;
        }
        
        LoadResources();
        ReRool();
    }
    public void ReRool()
    {
        for (int i = 0; i < EnemySlot.Length; i++)
        {
            if (EnemySlot[i].transform.childCount == 0)
            {

                GameObject instance = Instantiate(testTube, EnemySlot[i].transform);

                Tube tube = instance.GetComponent<Tube>(); //SO Setup
                foreach (var tubeSO in tubeSOs)
                {
                    var testTubeSO = tubeSOs[Random.Range(0, maxRangeSpawnTestTube)];
                    tube.SetupTube(testTubeSO.Name, testTubeSO.id, testTubeSO.Color, testTubeSO.Damage, testTubeSO.Period);
                }
            }
        }
    }
    private void LoadResources()
    {
        tubeSOs = Resources.LoadAll("StartingTubes", typeof(TubeSO))
            .Cast<TubeSO>()
            .ToArray();
    }
}
