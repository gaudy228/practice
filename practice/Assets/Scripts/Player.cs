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

    [SerializeField] private Consumables consumables;
    [SerializeField] private float plusHPCon;
    [SerializeField] private GameObject GameOver;
    [SerializeField] private GameObject ButtonPause;
    private void Start()
    {
        currHealth = maxHealth;
        showAmountOfHp.text = $"{currHealth}  /  {maxHealth}";
    }

    private void Update()
    {
        if (consumables.healing)
        {
            
            if(currHealth + plusHPCon > maxHealth)
            {
                currHealth = maxHealth;
            }
            else if (currHealth < maxHealth)
            {
                currHealth += plusHPCon;
            }
            healthBarFillAmount = currHealth / maxHealth;
            healthBar.fillAmount = healthBarFillAmount;
            showAmountOfHp.text = $"{currHealth} / {maxHealth}";
            consumables.healing = false;
        }
    }
    public void TakeDamage(int damage)
    {
        currHealth -= damage;
        if (currHealth <= 0)
        {
            
            GameOver.SetActive(true);
            ButtonPause.SetActive(false);
        }

        healthBarFillAmount = currHealth / maxHealth;

        healthBar.fillAmount = healthBarFillAmount;

        showAmountOfHp.text = $"{currHealth} / {maxHealth}";

        SoundFXManager.SFXinstance.PlaySoundFXClip(takeDamageClip, transform, 0.1f);
    }


}
