using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _size;

    private Queue<GameObject> _gameObjects = new Queue<GameObject>();

    public void Initialize()
    {
        for (int i = 0; i < _size; i++)
        {
            GameObject gameObject = Instantiate(_prefab);

            gameObject.SetActive(false);
            _gameObjects.Enqueue(gameObject);
        }
    }

    public GameObject TryGetObject()
    {
        if (_gameObjects.Count > 0)
        {
            GameObject gameObject = _gameObjects.Dequeue();
            gameObject.SetActive(true);

            return gameObject;
        }

        return null;
    }

    public void ReturnGameObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
        _gameObjects.Enqueue(gameObject);
    }
}