using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Booster : MonoBehaviour
{
    [SerializeField] private float _boostValue;
    [SerializeField] private float _boostTime;

    public event UnityAction<Booster> Boosting;

    public float BoostValue => _boostValue;
    public float BoostTime => _boostTime;

    private void OnDisable()
    {
        Boosting?.Invoke(this);
    }
}
