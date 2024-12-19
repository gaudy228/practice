using UnityEngine;
using UnityEngine.UI;

public class Tube : MonoBehaviour
{
    [SerializeField] public string tubeName;
    [SerializeField] public int damage;
    [SerializeField] public int period;



    public void SetupTube(string Name, Color Color, int Damage, int Period)
    {
        tubeName = Name;
        period = Period;
        damage = Damage;
        gameObject.GetComponent<Image>().color = Color;
    }
}
