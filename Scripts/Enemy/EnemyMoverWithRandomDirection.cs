using UnityEngine;

public class EnemyMoverWithRandomDirection : EnemyMover
{
    private Vector3 _direction;
    
    public override void Move()
    {
        transform.Translate(_direction * _currentSpeed * Time.deltaTime, Space.Self);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}