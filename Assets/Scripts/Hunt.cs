using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hunt : MonoBehaviour
{
    [SerializeField] private List<NPC> _targets;
    [SerializeField] private float _time;

    public event UnityAction AllTargetsDead;
    public event UnityAction<NPC> CollisionOccured;
    public event UnityAction HuntTimeOver;

    private void OnEnable()
    {
        CollisionOccured += OnCollisionOccured;
    }

    private void OnDisable()
    {
        CollisionOccured -= OnCollisionOccured;
    }

    private void Update()
    {
        _time -= Time.deltaTime;

        if (_time < 0 && _time > -1)
        {
            HuntTimeOver?.Invoke();
        }
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

    public void ResetTime()
    {
        _time = 3;
    }

    private void OnCollisionOccured(NPC npc)
    {
        _targets.Remove(npc);
    }
}
