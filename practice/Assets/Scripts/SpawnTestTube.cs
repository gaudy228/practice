using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTestTube : MonoBehaviour
{
    private MoveTestTube moveTestTube;
    

    private void Start()
    {
        moveTestTube = GameObject.FindGameObjectWithTag("ManagerUI").GetComponent<MoveTestTube>();
        for (int i = 0; i < moveTestTube.Slots.Length; i++)
        {
            if (moveTestTube.isFull[i] == false)
            {
                moveTestTube.isFull[i] = true;
                Instantiate(moveTestTube.testTube, moveTestTube.Slots[i].transform);

            }
        }
    }
    private void Update()
    {
       
    }
}
