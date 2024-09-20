using UnityEngine;

public abstract class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField] protected EnemyMover _prefab;

    public abstract void SpawnEnemy();
}