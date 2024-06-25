using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Vector3 _durations;

    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;

    [SerializeField] private float _currentSpeed;

    private void OnValidate()
    {
        _currentSpeed = Mathf.Clamp(_currentSpeed, _minSpeed, _maxSpeed);

        if (_minSpeed > _maxSpeed)
        {
            _minSpeed = _maxSpeed - 1;
        }
    }

    public void Move()
    {
        transform.Translate(_durations * _currentSpeed * Time.deltaTime, Space.Self);
    }
}