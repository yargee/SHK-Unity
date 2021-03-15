using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Booster : Npc
{
    [SerializeField] private float _boostValue;
    [SerializeField] private float _boostTime;
    [SerializeField] private SpriteRenderer _sprite;

    private bool _npcBoosted = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMovement mover) && !_npcBoosted)
        {
            _npcBoosted = true;
            StartCoroutine(mover.Boost(_boostValue, _boostTime));
            StartCoroutine(DelayedDeath());
        }
    }

    private IEnumerator DelayedDeath()
    {
        _sprite.enabled = false;
        yield return new WaitForSeconds(_boostTime);
        Die();
    }
}
