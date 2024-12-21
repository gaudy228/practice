using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSlot : MonoBehaviour
{
    private bool isPlay = false;
    [SerializeField] private ManagerTestTube managerTestTube;
    private void Update()
    {
        if (isPlay)
        {
            
            
            isPlay = false;
        }
    }
    public void GoPlay()
    {
        isPlay = true;
        
        managerTestTube.ReRool();
        ClearChildren();
    }
    private void ClearChildren()
    {
        
        int i = 0;

        
        GameObject[] allChildren = new GameObject[transform.childCount];

        
        foreach (Transform child in transform)
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
