using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;

    public int currHealth;

    private float healthBarFillAmount;

    [SerializeField] private Image healthBar;

    [SerializeField] private TextMeshProUGUI showAmountOfHp;

    private void Start()
    {
        currHealth = maxHealth;
        showAmountOfHp.text = $"{currHealth} / {maxHealth}";
    }


    public void TakeDamage(int damage)
    {
        currHealth -= damage;
        if (currHealth < 0)
        {
            //Game Over
        }

        healthBarFillAmount = (float)currHealth / (float)maxHealth;

        healthBar.fillAmount = healthBarFillAmount;

        showAmountOfHp.text = $"{ currHealth} / { maxHealth}";
    }

}