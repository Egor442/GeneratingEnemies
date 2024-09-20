using UnityEngine;

public class EnemyMoverWithTarget : EnemyMover
{
    private Transform _target;

    public override void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _currentSpeed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

}