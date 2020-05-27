using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _speed;

    private int currendPoint;

    private void Start()
    {
        _enemy.Speed = _speed;
        _enemy.Target = _points[0];
    }

    private void Update()
    {
        Transform target = _points[currendPoint];
        _enemy.Target = target;

        if (_enemy.transform.position == target.position)
        {
            currendPoint++;
            if (currendPoint >= _points.Length)
            {
                currendPoint = 0;
            }
        }
    }
}
