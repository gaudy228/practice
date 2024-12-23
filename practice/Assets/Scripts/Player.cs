using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [HideInInspector] public float currHealth;

    private float healthBarFillAmount;
    [SerializeField] private Image healthBar;

    [SerializeField] private TextMeshProUGUI showAmountOfHp;

    [SerializeField] private AudioClip takeDamageClip;
    private void Start()
    {
        currHealth = maxHealth;
        showAmountOfHp.text = $"{currHealth}  /  {maxHealth}";
    }


    public void TakeDamage(int damage)
    {
        currHealth -= damage;
        if (currHealth < 0)
        {
            //Game Over
        }

        healthBarFillAmount = currHealth / maxHealth;

        healthBar.fillAmount = healthBarFillAmount;

        showAmountOfHp.text = $"{currHealth} / {maxHealth}";

        SoundFXManager.SFXinstance.PlaySoundFXClip(takeDamageClip, transform, 0.1f);
    }


}
