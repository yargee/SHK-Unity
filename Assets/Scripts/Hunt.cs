using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hunt : MonoBehaviour
{
    [SerializeField] private List<Enemy> _targets;

    public event UnityAction AllTargetsDead;
    public event UnityAction<Enemy> CollisionOccured;

    private void OnEnable()
    {
        CollisionOccured += OnCollisionOccured;
    }

    private void OnDisable()
    {
        CollisionOccured -= OnCollisionOccured;
    }

    public void CheckTargetsPosition()
    {
        for (int i = 0; i < _targets.Count; i++)
        {
            if (Vector3.Distance(transform.position, _targets[i].transform.position) < 0.2f)
            {
                CollisionOccured?.Invoke(_targets[i]);

                if (_targets.Count == 0)
                {
                    AllTargetsDead?.Invoke();
                }
            }
        }
    }

    private void OnCollisionOccured(Enemy enemy)
    {
        _targets.Remove(enemy);
    }
}
