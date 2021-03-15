using System;
using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3;

    public void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontalMove, verticalMove, 0);
        transform.Translate(direction * _speed * Time.deltaTime);
    }
    
    public void ChangeSpeed(float value)
    {
        _speed *= value;
    }

    public IEnumerator Boost(float value, float time)
    {
        ChangeSpeed(value);
        yield return new WaitForSeconds(time);
        ChangeSpeed(1 / value);
    }
}
