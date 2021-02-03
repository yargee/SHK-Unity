using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Hunt))]
[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] private Hunt _hunt;
    [SerializeField] private PlayerMovement _mover;
    
    private void Update()
    {
        _mover.Move();
        _hunt.CheckTargetsPosition();
    }
}
