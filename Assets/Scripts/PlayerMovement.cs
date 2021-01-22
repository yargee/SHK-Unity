using UnityEngine;

[RequireComponent(typeof(HuntTimer))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private HuntTimer _huntTimer;

    private void OnEnable()
    {
        _huntTimer.HuntTimeIsOver += OnHuntTimeIsOver;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector2.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(Vector2.down);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector2.right);
        }
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void OnHuntTimeIsOver()
    {
        _huntTimer.HuntTimeIsOver -= OnHuntTimeIsOver;
        _speed /= 2;
    }
}
