using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarDucks.Abstract.Spawners;

namespace StarDucks.Spawners
{
    public class BossSpawner : BaseSpawner
    {
      
        [SerializeField] GameObject boss;

      
        protected override void Spawn()
        {
            
            Instantiate(boss,this.transform);
            
        }

       
    }
}



