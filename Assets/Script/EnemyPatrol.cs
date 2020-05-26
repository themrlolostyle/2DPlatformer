using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Transform _enemy;
    [SerializeField] private float _speed;

    private int currendPoint;

    private void Update()
    {
        Transform target = _points[currendPoint];

        _enemy.position = Vector3.MoveTowards(_enemy.transform.position, target.position, _speed * Time.deltaTime);

        if (_enemy.position == target.position)
        {
            currendPoint++;
            if (currendPoint >= _points.Length)
            {
                currendPoint = 0;
            }
        }
        
    }
}
