using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
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
            //Next Enemy
        }

        healthBarFillAmount = (float)currHealth / (float)maxHealth;

        healthBar.fillAmount = healthBarFillAmount;

        showAmountOfHp.text = $"{currHealth} / {maxHealth}";
    }
}
