using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2;

    private Vector3 _movePoint;

    private void Start()
    {
        FindNewMovePoint();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _movePoint, _speed * Time.deltaTime);
        if (transform.position == _movePoint)
        {
            FindNewMovePoint();
        }
    }

    private void FindNewMovePoint()
    {
        _movePoint = Random.insideUnitCircle * 4;
    }
}
