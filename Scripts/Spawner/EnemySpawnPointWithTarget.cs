using UnityEngine;

public class EnemySpawnPointWithTarget : EnemySpawnPoint
{
    [SerializeField] private Transform _target;

    public override void SpawnEnemy()
    {
        EnemyMoverWithTarget enemyMover = (EnemyMoverWithTarget)Instantiate(_prefab, transform);
        enemyMover.SetTarget(_target);
    }
}