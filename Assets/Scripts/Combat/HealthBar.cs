using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBarFilling;
    [SerializeField] PlayerHealth _health;

    private Camera _camera;

    private void Awake()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    private void OnDestroy()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float valueAsPercantage)
    {
        Debug.Log(valueAsPercantage);
        _healthBarFilling.fillAmount = valueAsPercantage;
    }
}
