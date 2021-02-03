using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Hunt))]
public class Player : MonoBehaviour
{
    [SerializeField] private Hunt _hunt;
    
    private void Update()
    {
        _hunt.CheckTargetsPosition();
    }
}
