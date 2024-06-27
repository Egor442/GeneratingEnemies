using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
       
    public void SpawnEnemy()
    {
        Enemy enemy = Instantiate(_prefab, transform);
        enemy.SetDirection(GenerateRandomDirection());
    }

    private Vector3 GenerateRandomDirection()
    {
        Vector3 direction;
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        return direction;
    }
}