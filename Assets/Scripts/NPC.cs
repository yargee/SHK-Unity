using UnityEngine;

[RequireComponent(typeof(NPCMovement))]
public class NPC : MonoBehaviour
{
    [SerializeField] private Hunt _hunt;
    [SerializeField] private NPCMovement _mover;

    private void OnEnable()
    {
        _hunt.CollisionOccured += OnCollisionOccured;
    }

    private void OnDisable()
    {
        _hunt.CollisionOccured -= OnCollisionOccured;
    }

    private void Update()
    {
        _mover.Move();
    }

    public void OnCollisionOccured(NPC npc)
    {        
        Destroy(npc.gameObject);        
    }
}
