using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] private List<NPC> _enemys;

    public event UnityAction AllTargetsDead;

    private void OnEnable()
    {
        foreach(var enemy in _enemys)
        {
            enemy.Killed += OnEnemyKilled;
        }
    }

    private void OnEnemyKilled(NPC enemy)
    {
        enemy.Killed -= OnEnemyKilled;
        _enemys.Remove(enemy);

        if(_enemys.Count == 0)
        {
            AllTargetsDead?.Invoke();
        }
    }
}
