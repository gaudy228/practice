using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnTestTube : MonoBehaviour
{
    private MoveTestTube moveTestTube;

    private GameObject instance;

    private TubeSO[] tubeSOs;

    private void Start()
    {
        LoadResources();
        moveTestTube = GameObject.FindGameObjectWithTag("ManagerUI").GetComponent<MoveTestTube>();
        for (int i = 0; i < moveTestTube.Slots.Length; i++)
        {
            if (moveTestTube.isFull[i] == false)
            {
                moveTestTube.isFull[i] = true;
                instance = Instantiate(moveTestTube.testTube, moveTestTube.Slots[i].transform);

                Tube tube = instance.GetComponent<Tube>(); //SO Setup
                foreach (var tubeSO in tubeSOs)
                {
                    var testTubeSO = tubeSOs[Random.Range(0, tubeSOs.Length)];
                    tube.SetupTube(testTubeSO.Name, testTubeSO.Color, testTubeSO.Damage, testTubeSO.Period);
                }
            }
        }
    }
    private void Update()
    {
       
    }

    private void LoadResources()
    {
        tubeSOs = Resources.LoadAll("StartingTubes", typeof(TubeSO))
            .Cast<TubeSO>()
            .ToArray();
    }
}