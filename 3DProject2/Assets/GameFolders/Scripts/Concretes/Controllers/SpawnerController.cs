using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] EnemyController _enemyPrefab;
        [Range(0.1f, 5f)] [SerializeField] float _min = 0.1f;
        [Range(6f, 15f)] [SerializeField] float _max = 15f;



        float _maxSpawnTime = 10f;
        float _currentSpawnTime = 0f;

        private void OnEnable()
        {
            _maxSpawnTime = Random.Range(_min, _max);
            GetRandomMaxTime();
        }



        private void Update()
        {

            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _maxSpawnTime)
            {
                Spawn();
            }
            
        }

        void Spawn()
        {
            EnemyController newEnemy =  Instantiate(_enemyPrefab, transform.position, transform.rotation);
            newEnemy.transform.parent = this.transform;
            _currentSpawnTime = 0f;
            GetRandomMaxTime();

        }

        private void GetRandomMaxTime()
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }


    }

}

