using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private ObjectPool _pool;
    [SerializeField] private Spawner _spawner;

    private void Awake()
    {
        _pool.Initialize();
        _spawner.Initialize();
    }
}