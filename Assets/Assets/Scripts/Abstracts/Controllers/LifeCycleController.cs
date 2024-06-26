﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarDucks.Abstract.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {

        [SerializeField] float maxLifeTime = 3f;
        

        float _currentTime;

        private void Update()
        {
                _currentTime += Time.deltaTime;

                if (_currentTime > maxLifeTime)
                {
                    Destroy(this.gameObject);
                }
            
            
        }
    }
}


