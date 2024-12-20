using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int maxHealth;

    private int currHealth;

    private float healthBarFillAmount;

    [SerializeField] private Image healthBar;

<<<<<<< Updated upstream
=======
    [SerializeField] private Transform healthBarRoot;

>>>>>>> Stashed changes
    [SerializeField] private TextMeshProUGUI showAmountOfHp;

    private void Start()
    {
<<<<<<< Updated upstream
=======
        Instantiate(healthBar, healthBarRoot); // If requires to be instantiated
>>>>>>> Stashed changes
        currHealth = maxHealth;
        showAmountOfHp.text = $"{currHealth.ToString()} / {maxHealth.ToString()}";
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

        showAmountOfHp.text = $"{currHealth.ToString()} / {maxHealth.ToString()}";
    }
}
