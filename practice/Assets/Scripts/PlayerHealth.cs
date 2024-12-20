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
        showAmountOfHp.text = $"{currHealth.ToString()} / {maxHealth.ToString()}";
    }


    public void TakeDamage(int damage)
    {
        currHealth -= damage;
        if (currHealth < 0)
        {
            //Game Over
        }
        Debug.Log(currHealth);
        Debug.Log(maxHealth);

        healthBarFillAmount = (float)currHealth / (float)maxHealth;

        Debug.Log(healthBarFillAmount);

        healthBar.fillAmount = healthBarFillAmount;

        showAmountOfHp.text = $"{ currHealth.ToString() } / { maxHealth.ToString() }";
    }

}