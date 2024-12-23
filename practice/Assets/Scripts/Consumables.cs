
using UnityEngine;
using UnityEngine.UI;

public class Consumables : MonoBehaviour
{
    [SerializeField] private GameObject[] Slot;
    [SerializeField] private GameObject[] Consumabl;

    private void Start()
    {
        ReRool();
    }
    public void ReRool()
    {
        for (int i = 0; i < Slot.Length; i++)
        {
            if (Slot[i].transform.childCount == 0)
            {
                int rnd = Random.Range(0, Consumabl.Length);
                GameObject con = Instantiate(Consumabl[rnd], Slot[i].transform);
                con.GetComponent<Button>().onClick.AddListener(C);
            }
        }
    }
    public void C()
    {
        Debug.Log("0");
        
    }
}
