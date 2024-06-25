using UnityEngine;

[RequireComponent (typeof(ObjectPool))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elepsedTime;
    private ObjectPool _pool;

    private Transform[] _spawnPoints;

    public void Initialize()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();
        _pool = GetComponent<ObjectPool>();
    }

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime >= _secondsBetweenSpawn)
        {
            GameObject gameObject = _pool.TryGetObject();

            if (gameObject != null)
            {
                int spawnPointRandom = Random.Range(0, _spawnPoints.Length);
                gameObject.transform.position = _spawnPoints[spawnPointRandom].position;
            }

            _elepsedTime = 0;
        }
    }
}