using System;
using UnityEngine;

[RequireComponent(typeof(Hunt))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private Hunt _hunt;

    private void OnEnable()
    {
        _hunt.HuntTimeOver += OnHuntTimeOver;
        _hunt.CollisionOccured += OnCollisionOccured;
    }

    private void OnDisable()
    {
        _hunt.HuntTimeOver -= OnHuntTimeOver;
    }

    private void OnCollisionOccured(NPC npc)
    {
        if (npc.TryGetComponent(out Booster booster))
        {
            _speed *= 3;
            _hunt.HuntTimeOver += OnHuntTimeOver;
            _hunt.ResetTime();
        }
    }

    public void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontalMove, verticalMove, 0);
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void OnHuntTimeOver()
    {
        _hunt.HuntTimeOver -= OnHuntTimeOver;        
        _speed = 2;
    }
}
