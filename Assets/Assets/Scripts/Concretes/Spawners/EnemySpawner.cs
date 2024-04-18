using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarDucks.Controller;
using StarDucks.Movements;
using StarDucks.Abstract.Spawners;

namespace StarDucks.Spawners
{
    public class EnemySpawner : BaseSpawner
    {
       
        [SerializeField] GameObject[] enemies;    

        protected override void Spawn()
        {
            int enemyIndex = Random.Range(0, enemies.Length - 1);
            //Instantiate(enemy,transform.position,transform.rotation);
            Instantiate(enemies[enemyIndex],new Vector3(Random.Range(8.5f,10.5f),Random.Range(3f,-4f),0),Quaternion.identity);
        }

        
    }

}
