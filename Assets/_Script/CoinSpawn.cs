using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    [SerializeField] private Transform _coin;

    private Transform[] _spawnPoints;
    private int _currentPoint = 0;

    private void Start()
    {
        _spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoints[i] = transform.GetChild(i);
        }
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var whaitForOneSeconds = new WaitForSeconds(2f);

        while (true)
        {
            Instantiate(_coin, _spawnPoints[_currentPoint].position, Quaternion.identity);

            _currentPoint++;
            if (_currentPoint >= _spawnPoints.Length)
            {
                _currentPoint = 0;
            }

            yield return whaitForOneSeconds;
        }
    }
}

