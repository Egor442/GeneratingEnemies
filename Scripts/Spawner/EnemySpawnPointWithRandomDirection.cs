using UnityEngine;

public class EnemySpawnPointWithRandomDirection : EnemySpawnPoint
{
    public override void SpawnEnemy()
    {
        EnemyMoverWithRandomDirection enemyMover = (EnemyMoverWithRandomDirection)Instantiate(_prefab, transform);
        enemyMover.SetDirection(GenerateRandomDirection());
    }

    private Vector3 GenerateRandomDirection()
    {
        Vector3 direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        return direction;
    }
}