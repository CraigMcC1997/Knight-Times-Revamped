using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public TMP_Text TextHealth;

    private const float MAX_HEALTH = 100f;
    private const float MIN_HEALTH = 0f;
    public float health;

    void Start()
    {
        health = MAX_HEALTH;
    }

    public void takeDamage()
    {
        if (health > MIN_HEALTH)
            health -= 10f;
        else
        {
            health = 0;
            //kill player:
                // - update health logo to dead one
                // - pause for a second and then start again / send to main menu
        }
    }

    void Update()
    {
        TextHealth.text = health.ToString();
        healthBar.fillAmount = health / MAX_HEALTH;
    }
}
