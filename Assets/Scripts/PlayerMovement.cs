﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3;

    public void OnTimeIsOver()
    {
        _speed /= 2;
    }

    void Update()
    {       
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }            
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }            
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }           
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }            
    }
}
