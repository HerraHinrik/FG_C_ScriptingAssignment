using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private string playerName;
    [SerializeField] private Image healthBar;
    [SerializeField] private GameObject winMenu;

    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            winMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
