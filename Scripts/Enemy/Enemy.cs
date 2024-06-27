using UnityEngine;

[RequireComponent(typeof(EnemyMover))]
public class Enemy : MonoBehaviour
{
    private EnemyMover _enemyMover;

    private void Awake()
    {
        _enemyMover = GetComponent<EnemyMover>();
    }

    private void Update()
    {
        _enemyMover.Move();
    }

    public void SetDirection(Vector3 direction)
    {
        _enemyMover.SetDirection(direction);
    }
}