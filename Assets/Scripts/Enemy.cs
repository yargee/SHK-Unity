using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Hunt _hunt;

    private void OnEnable()
    {
        _hunt.CollisionOccured += OnCollisionOccured;
    }

    private void OnDisable()
    {
        _hunt.CollisionOccured -= OnCollisionOccured;
    }

    public void OnCollisionOccured(Enemy enemy)
    {
        Destroy(enemy.gameObject);        
    }
}
