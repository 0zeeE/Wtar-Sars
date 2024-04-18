using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarDucks.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
   
    public class Mover : MonoBehaviour
    {
        
        [SerializeField] float hareketHizi = 4f; //ilerleme sırasındaki hızı
        [SerializeField] float ilerlemeSure = 1.5f; //Süre bittikten sonra hareketi durdurmak için gereken süre

        float _currentTime;
        Rigidbody2D _rigidbody2D;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            //Düşmanın harita dışından gelerek oyuncuya belirmesi
            _currentTime += Time.deltaTime;

            if(_currentTime > ilerlemeSure)
            {
                hareketHizi = 0f;
            }

            _rigidbody2D.velocity = Vector2.left * hareketHizi;

        }

        
    }
}
