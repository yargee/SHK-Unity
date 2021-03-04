using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(NpcMovement))]
public class NPC : MonoBehaviour
{    
    [SerializeField] private NpcMovement _mover;

    public event UnityAction<NPC> NpcKilled;

    private void Update()
    {
        _mover.Move();
    }

    public void Die()
    {
        NpcKilled?.Invoke(this);
        Destroy(gameObject);
    }
}
