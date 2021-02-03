using UnityEngine;

[RequireComponent(typeof(HuntTimer))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private HuntTimer _huntTimer;

    private void OnEnable()
    {
        _huntTimer.HuntTimeOver += OnHuntTimeOver;
    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontalMove, verticalMove, 0);

        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void OnHuntTimeOver()
    {
        _huntTimer.HuntTimeOver -= OnHuntTimeOver;
        //_speed /= 2;
    }
}
