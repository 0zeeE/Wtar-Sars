using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarDucks.Combat;

namespace StarDucks.controller
{
    public class PlayerMovements : MonoBehaviour
    {
        public Health health;
        Rigidbody2D rb2D; // rb2D = rigidbody2D field kısaltması
        [SerializeField] private float maksHiz = 5f; //Oyuncunun temel hızını düzenlemek için sadece bunu değiştir.
        LaunchProjectile _launchProjectile;
        
        
        
        
        void Start()
        {
            
        }

        private void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
            _launchProjectile = GetComponent<LaunchProjectile>(); //mermi çağırma metodu
        }

        // Update is called once per frame
        void Update()
        {
            //Unity input manager üzerinden çoklu platform buildleri için ekstradan atamalar ve ayarlamalar yapılmalı.

            //oyuncuyu hareket ettir

            
                Vector3 pos = transform.position;
                pos.y += Input.GetAxis("Vertical") * maksHiz * Time.deltaTime;
                pos.x += Input.GetAxis("Horizontal") * maksHiz * Time.deltaTime;
                transform.position = pos;

                if (Input.GetKeyDown(KeyCode.Space)) //BUG: oyuncunun tıklama hızına göre sonsuz atış yapabiliyor.
                {
                    _launchProjectile.LaunchAction();
                }
            
            
             
            

    
        }

        private void FixedUpdate()
        {

        }
    }


}

//Ölme sırasında kullanılacak düşme animasyonu

//transform.position += new Vector3(0.02f,0.003f);
//transform.Rotate(0f, 0.7f, 0f, 0f);
