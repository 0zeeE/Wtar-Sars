using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarDucks.Abstract.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {

        [SerializeField] float maxSpawnTime = 3f;
        [SerializeField] float minSpawnTime = 1f;

        float _currentSpawnTime;
        float _timeBoundary;

        void Start()
        {
            ResetTime();
        }


        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTime();
            }
        }

        private void ResetTime() //Zamanı sıfırlamak ve tekrardan almak için eklenmiş bir metot
        {
            _currentSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }

        protected abstract void Spawn();
        
            
       
    }
}

