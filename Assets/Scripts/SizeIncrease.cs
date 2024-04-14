using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncrease : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxScale;

    private float _currentScale = 1;
    private Vector3 _startScale;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        _currentScale += _speed * Time.deltaTime;

        if (_currentScale >= _maxScale)
        {
            transform.localScale = _startScale;

            _currentScale = 1;
        }

        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
