using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private float _maxDistance;

    private float _currentDistance = 0;

    private void Update()
    {
        _currentDistance += _speed * Time.deltaTime;

        if(_currentDistance >= _maxDistance)
        {
            _currentDistance = 0;

            transform.position = _startPoint.position;
        }

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
