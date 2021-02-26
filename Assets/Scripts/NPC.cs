using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(NPCMovement))]
public class NPC : MonoBehaviour
{    
    [SerializeField] private NPCMovement _mover;

    public event UnityAction<NPC> Killed;

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
