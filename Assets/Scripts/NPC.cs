using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(NpcMovement))]
public class Npc : MonoBehaviour
{    
    [SerializeField] private NpcMovement _mover;

    public event UnityAction<Npc> Killed;

    private void Update()
    {
        _mover.Move();
    }

    public void Die()
    {
        Killed?.Invoke(this);
        Destroy(gameObject);
    }
}
