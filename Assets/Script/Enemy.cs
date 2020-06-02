using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed;

    private int _currentPoint;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _points[_currentPoint].position, _speed * Time.deltaTime);

        if (transform.position == _points[_currentPoint].position)
        {
            _currentPoint++;
            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
