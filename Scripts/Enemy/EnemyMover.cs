using UnityEngine;

public abstract class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;

    [SerializeField] protected float _currentSpeed;
   
    private void OnValidate()
    {
        _currentSpeed = Mathf.Clamp(_currentSpeed, _minSpeed, _maxSpeed);

        if (_minSpeed > _maxSpeed)
        {
            _minSpeed = _maxSpeed - 1;
        }
    }

    private void Update()
    {
        Move();
    }

    public abstract void Move();
}