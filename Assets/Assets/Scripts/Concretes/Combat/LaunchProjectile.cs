using StarDucks.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarDucks.Combat
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] GameObject projectileParent; //Inspector üzerindeki kalabalığı azaltmak için bir boş Object i parent yaptım.

        
        //Random projectile speed psödokod (Enemy için farklı bir projectileLaunch script yazdır)

        /*
         
        float hız araliği;
        float minhiz, maxhiz;
        hiz araligi = Range(minhiz,maxhiz);


        */

        public void LaunchAction() //Mermiyi fırlatma özelliği
        {
            
            
                ProjectileController newProjectile = Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.rotation);
                newProjectile.transform.parent = projectileParent.transform;  //Referans verilecek objeye mermileri dolduracak
                
            
        }

       
    }

}
