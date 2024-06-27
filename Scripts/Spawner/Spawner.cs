using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _secondsBetweenSpawn;

    private EnemySpawnPoint[] _spawnPoints;
    private Coroutine _coroutine;

    public void Initialize()
    {
        _spawnPoints = GetComponentsInChildren<EnemySpawnPoint>();
    }

    private void Start()
    {
        _coroutine = StartCoroutine(CountDown(_secondsBetweenSpawn));
    }

    private IEnumerator CountDown(float delay)
    {
        while (enabled)
        {
            yield return new WaitForSeconds(delay);
            _spawnPoints[GetRandomSpawnPoint()].SpawnEnemy();
        }
    }
   
    private int GetRandomSpawnPoint()
    {
        int spawnPointRandom = Random.Range(0, _spawnPoints.Length);
        return spawnPointRandom;
    }
}