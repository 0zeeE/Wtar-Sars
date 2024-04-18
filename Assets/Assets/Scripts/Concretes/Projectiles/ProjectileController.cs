using StarDucks.Abstract.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarDucks.Controller
{
    public class ProjectileController : LifeCycleController
    {
        private void OnTriggerEnter2D(Collider2D collision) //Düşmanlar mermiye dokununca verilecek tepki
        {
            EnemyController enemy = collision.GetComponent<EnemyController>();
            float damage = 0.5f;
           
            

            if (enemy != null)
            {
                GameManager.Instance.IncreaseScore();
                Destroy(enemy.gameObject);
                Destroy(this.gameObject);
            }

            if(collision.tag == "Player")
            {
                collision.GetComponent<Health>().TakeDamage(damage);
            }
        }
    }

}
