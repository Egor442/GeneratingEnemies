using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ObjectPool))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elepsedTime;
    private ObjectPool _pool;

    private SpawnPoint[] _spawnPoints;
    private Coroutine _coroutine;

    public void Initialize()
    {
        _spawnPoints = GetComponentsInChildren<SpawnPoint>();
        _pool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        _coroutine = StartCoroutine(CountDown(_secondsBetweenSpawn));
    }

    private IEnumerator CountDown(float delay)
    {
        var wait = new WaitForSeconds(delay);

        while (enabled)
        {
            yield return wait;
            TrySpawn();
        }
    }

    private void TrySpawn()
    {
        GameObject gameObject = _pool.TryGetObject();

        if (gameObject != null)
        {
            gameObject.transform.position = _spawnPoints[GetRandomSpawnPoint()].transform.position;
            gameObject.transform.forward = _spawnPoints[GetRandomSpawnPoint()].GenerateRandomDirection();
        }
    }
    
    private int GetRandomSpawnPoint()
    {
        int spawnPointRandom = Random.Range(0, _spawnPoints.Length);
        return spawnPointRandom;
    }
}