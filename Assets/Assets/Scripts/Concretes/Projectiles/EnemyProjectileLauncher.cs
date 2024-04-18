using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileLauncher : MonoBehaviour
{
    [SerializeField] Transform projectileLaunch;
    [SerializeField] GameObject projectile;
    [SerializeField] float launchTime = 0.8f;

    private float _currentTime;

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if(_currentTime > launchTime)  //_currentTime > launchTime
        {
            Instantiate(projectile, projectileLaunch.position, projectileLaunch.rotation);
            _currentTime = 0;
        }
    }

}


