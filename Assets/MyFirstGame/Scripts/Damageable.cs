using UnityEngine;
using TMPro;
using System;
using System.Collections;

class Damageable : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] TMP_Text healthText;

    [SerializeField] Behaviour behaviour;
    [SerializeField] float invincibilityFrames = 1;

    float invincibilityStarted;
    bool isInvincible = false;

    int startHealth;


    void Start()
    {
        startHealth = health;
        health = PlayerPrefs.GetInt("health", health);
        UpdateText();
    }

    /*
    void Update()
    {
        if (isInvincible)
        {
            if (Time.time > invincibilityStarted + invincibilityFrames)
            {
                isInvincible = false;
            }

            return;
        }
    }
    */

    public void Damage(int damage)
    {
        if (isInvincible)
        {
            return;
        }

        health -= damage;
        
        // invincibilityStarted = Time.time;
        PlayerPrefs.SetInt("health", health);

        StartCoroutine(InvincibilityCoroutine());

        if (health < 0)
            health = 0;

        if (health == 0)
        {
            behaviour.enabled = false;
            PlayerPrefs.SetInt("health", startHealth);
        }

        UpdateText();
    }

    IEnumerator InvincibilityCoroutine()
    {
        const float flickTime = 0.05f;

        isInvincible = true;

        bool visible = false;

        for (int i = 0; i < invincibilityFrames / flickTime; i++)
        {
            SetVisibility(visible);
            visible = !visible;
            yield return new WaitForSeconds(flickTime);
        }

        SetVisibility (true);
        isInvincible = false;
    }

    void SetVisibility(bool isVisible)
    {
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();

        foreach (var renderer in renderers)
        {
            renderer.enabled = isVisible;
        }
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
