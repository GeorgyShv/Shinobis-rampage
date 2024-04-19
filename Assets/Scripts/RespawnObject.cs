using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObject : MonoBehaviour
{
    [SerializeField] private Rigidbody _objectRigidbody;
    [SerializeField] private Collider _collider;
    [SerializeField] private Transform _spawnPosition;

    private void OnTriggerEnter(Collider _collider)
    {
        _objectRigidbody.transform.position = new Vector3(_spawnPosition.position.x, _spawnPosition.position.y, _spawnPosition.position.z);
        _objectRigidbody.velocity = new Vector3(0f, 0f, 0f);
    }
}
