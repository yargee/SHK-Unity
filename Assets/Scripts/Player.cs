using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject[] _targets;
    private int _targetsNumber;
    public UnityEvent AllTargetsAreDead;

    private void HuntOnTargets()
    {
        foreach (var target in _targets)
        {
            if (target == null)
            {
                continue;
            }
            if (Vector3.Distance(transform.position, target.transform.position) < 0.2f)
            {
                Destroy(target);
                _targetsNumber--;
                if (_targetsNumber <= 0)
                {
                    AllTargetsAreDead?.Invoke();
                }
            }
        }
    }

    private void Start()
    {
        _targetsNumber = _targets.Length;
    }   

    private void Update()
    {
        HuntOnTargets();
    }
}
