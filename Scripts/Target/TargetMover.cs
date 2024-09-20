using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed;

    private int _currentPoint;

    private void Start()
    {
        _currentPoint = 0;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position != _points[_currentPoint].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, _points[_currentPoint].position, _speed * Time.deltaTime);
        }
        else
        {
            _currentPoint = (_currentPoint + 1) % _points.Length;
        }
    }
}