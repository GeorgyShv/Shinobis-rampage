using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Enemy : MonoBehaviour, IDamageable
{
    [Header("Health stats")]
    [SerializeField] private int _maxHealth = 100;
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            ApplyDamage(-10);
    }

    public void ApplyDamage(int damageValue)
    {
        _currentHealth += damageValue;

        if (_currentHealth <= 0)
            Death();
    }

    private void Death()
    {
        Destroy(gameObject);
        Debug.Log("Враг повержен");
    }
}
