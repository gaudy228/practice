using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ManagerTestTube : MonoBehaviour
{
    
    public GameObject[] Slots;
    public GameObject testTube;
    private ManagerTestTube moveTestTube;



    private TubeSO[] tubeSOs;
    [HideInInspector] public int maxRangeSpawnTestTube;
    private void Awake()
    {
        maxRangeSpawnTestTube = PlayerPrefs.GetInt("MPS");
        
    }
    private void Start()
    {
        if (maxRangeSpawnTestTube == 0)
        {
            maxRangeSpawnTestTube = 3;
        }
       
        LoadResources();
        moveTestTube = GameObject.FindGameObjectWithTag("ManagerUI").GetComponent<ManagerTestTube>();
        ReRool();
    }
    public void ReRool()
    {
        for (int i = 0; i < moveTestTube.Slots.Length; i++)
        {
            if (moveTestTube.Slots[i].transform.childCount == 0)
            {

                GameObject instance = Instantiate(moveTestTube.testTube, moveTestTube.Slots[i].transform);

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
