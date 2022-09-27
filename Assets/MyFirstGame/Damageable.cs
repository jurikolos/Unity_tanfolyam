using UnityEngine;
using TMPro;
using System;

class Damageable : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] TMP_Text healthText;

    [SerializeField] Behaviour behaviour;

    void Start()
    {
        UpdateText();
    }
    public void Damage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;

        if (health == 0)
            behaviour.enabled = false;

        UpdateText();
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    void UpdateText()
    {
        if (healthText != null)

            healthText.text = "Health: " + health;
    }
}
