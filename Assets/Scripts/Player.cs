using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private List<GameObject> _targets;
    public event UnityAction AllTargetsAreDead;

    private void Update()
    {
        HuntOnTargets();
    }

    private void HuntOnTargets()
    {
        for (int i = 0; i < _targets.Count; i++)
        {
            if (Vector3.Distance(transform.position, _targets[i].transform.position) < 0.2f)
            {
                Destroy(_targets[i]);
                _targets.Remove(_targets[i]);

                if (_targets.Count == 0)
                {
                    AllTargetsAreDead?.Invoke();
                }
            }
        }
    }
}
