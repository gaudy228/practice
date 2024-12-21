using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSlot : MonoBehaviour
{
    
    [SerializeField] private ManagerTestTube managerTestTube;
    [SerializeField] private GameObject buttonGoPlay;
    private void Update()
    {
        if(transform.childCount > 0)
        {
            buttonGoPlay.SetActive(true);
        }
        else
        {
            buttonGoPlay.SetActive(false);
        }
    }
    public void GoPlay()
    {
        
        
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
