using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private float _attackDistance = 0.2f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            if (CanAttack(enemy))
            {
                enemy.Die();
            }
        }
    }

    public bool CanAttack(Npc npc)
    {
        return Vector3.Distance(transform.position, npc.transform.position) <= _attackDistance;
    }
}
