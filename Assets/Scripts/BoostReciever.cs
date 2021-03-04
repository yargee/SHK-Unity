using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class BoostReciever : MonoBehaviour
{
    [SerializeField] private PlayerMovement _mover;
    [SerializeField] private List<Booster> _boosters;

    private void OnEnable()
    {
        foreach (var booster in _boosters)
        {
            booster.Boosting += OnBoosting;
        }
    }

    public void OnBoosting(Booster booster)
    {
        var value = booster.BoostValue;
        var time = booster.BoostTime;
        
        StartCoroutine(Boost(value, time));
        _boosters.Remove(booster);
        booster.Boosting -= OnBoosting;
    }

    public IEnumerator Boost(float value, float time)
    {
        _mover.ChangeSpeed(value);
        yield return new WaitForSeconds(time);
        _mover.ChangeSpeed(1 / value);
    }
}
