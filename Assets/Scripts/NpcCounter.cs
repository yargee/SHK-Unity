using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NpcCounter : MonoBehaviour
{
    [SerializeField] private List<NPC> _npc;

    public event UnityAction AllNpcDead;

    private void OnEnable()
    {
        foreach(var enemy in _npc)
        {
            enemy.NpcKilled += OnNpcKilled;
        }
    }

    private void OnNpcKilled(NPC enemy)
    {
        enemy.NpcKilled -= OnNpcKilled;
        _npc.Remove(enemy);

        if(_npc.Count == 0)
        {
            AllNpcDead?.Invoke();
        }
    }
}
