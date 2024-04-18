using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarDucks.Enums;

namespace StarDucks.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class ProjectileMover : MonoBehaviour
    {
        

        // Start is called before the first frame update
        [SerializeField] float hareketHizi = 2.5f; //ilerleme sırasındaki hızı
        [SerializeField] float ilerlemeSure = 4f; //Süre bittikten sonra mermiyi yok etmek için gereken süre
        [SerializeField] DirectionEnum direction; //Inspector üzerinden mermi yönünü ayarlamak için Enum kullanıldı

        float _currentTime;
        Rigidbody2D _rigidbody2D;

        private void Start()
        {
            

            _rigidbody2D.velocity = SelectDirection() * hareketHizi;
        }
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            //Merminin haritada kat ettiği mesafe ve yok olma süresi
            _currentTime += Time.deltaTime;

            if (_currentTime > ilerlemeSure)
            {
                Destroy(this.gameObject);
            }

        }

        private Vector2 SelectDirection() //İki yön için de projectile yön ayırıcı eklendi
        {
            Vector2 selectedDirection;

            if (direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }
            return selectedDirection;

        }
    }
}

