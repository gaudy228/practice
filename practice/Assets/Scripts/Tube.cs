using UnityEngine;
using UnityEngine.UI;

public class Tube : MonoBehaviour
{
    [SerializeField] public string tubeName;
    [SerializeField] public int damage;
    [SerializeField] public int id;
    [SerializeField] public int period;



    public void SetupTube(string Name, int Id, Color Color, int Damage, int Period)
    {
        id = Id;
        tubeName = Name;
        period = Period;
        damage = Damage;
        gameObject.GetComponent<Image>().color = Color;
    }
}
