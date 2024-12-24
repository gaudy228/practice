
using UnityEngine;
using UnityEngine.UI;

public class Consumables : MonoBehaviour
{
    [SerializeField] private GameObject[] Slot;
    [SerializeField] private GameObject[] Consumabl;
    private GameObject[] ButtonCon = new GameObject[3];
    [HideInInspector] public bool dobleDamage = false;
    [HideInInspector] public bool hialing = false;
    [HideInInspector] public bool prediction = false;
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
                ButtonCon[i] = Instantiate(Consumabl[rnd], Slot[i].transform);
                if(rnd == 0)
                {
                    ButtonCon[i].GetComponent<Button>().onClick.AddListener(DoubleDamage);
                }
                if(rnd == 1)
                {
                    ButtonCon[i].GetComponent<Button>().onClick.AddListener(Healing);
                }
                if(rnd == 2)
                {
                    ButtonCon[i].GetComponent<Button>().onClick.AddListener(Prediction);
                }
                if(i == 0)
                {
                    ButtonCon[i].GetComponent<Button>().onClick.AddListener(ButtDestroy1);
                }
                if(i == 1)
                {
                    ButtonCon[i].GetComponent<Button>().onClick.AddListener(ButtDestroy2);
                }
                if(i == 2)
                {
                    ButtonCon[i].GetComponent<Button>().onClick.AddListener(ButtDestroy3);
                }
               
            }
        }
    }
    public void DoubleDamage()
    {
        dobleDamage = true;
        
    }
    public void Healing()
    {
        hialing = true;
        
    }
    public void Prediction()
    {
        prediction = true;
        
    }
    public void ButtDestroy1()
    {
        Destroy(ButtonCon[0].gameObject);
    }
    public void ButtDestroy2()
    {
        Destroy(ButtonCon[1].gameObject);
    }
    public void ButtDestroy3()
    {
        Destroy(ButtonCon[2].gameObject);
    }
}
