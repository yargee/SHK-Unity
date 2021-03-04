using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2;

    private float radius = 4;
    private Vector3 _movePoint;

    private void Start()
    {
        FindNewMovePoint();
    }

    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _movePoint, _speed * Time.deltaTime);
        if (transform.position == _movePoint)
        {
            FindNewMovePoint();
        }
    }

    private void FindNewMovePoint()
    {
        _movePoint = Random.insideUnitCircle * radius;
    }
}
