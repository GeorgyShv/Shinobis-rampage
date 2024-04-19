using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsOnCollide : MonoBehaviour
{
    [SerializeField] private GameObject _hint;

    private void OnTriggerEnter(Collider _playerCollider)
    {
        _hint.SetActive(true);
    }

    private void OnTriggerExit(Collider _playerCollider)
    {
        _hint.SetActive(false);
    }
}
