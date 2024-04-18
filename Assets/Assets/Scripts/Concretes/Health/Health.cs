using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Health : MonoBehaviour
    {
        [SerializeField] private float startingHealth;
        private Animator anim;
        [SerializeField] private bool _dead;
        [SerializeField] float freezeTime = 3f;

        float _currentTime;


        public bool _isdead { get; private set; }

    [SerializeField] GameObject gameOverPanel;

       

        public float currentHealth { get; private set; } //Dışarıdan müdahale edip sınırsız can açığı olmaması için private set kullandım.

        private void Awake()
        {
            currentHealth = startingHealth;
            anim = GetComponent<Animator>();
        }

    private void Update()
    {
        if (_isdead)
        {
            _currentTime += Time.deltaTime;

            if(_currentTime > freezeTime)
            {
                Time.timeScale = 0;
                _currentTime = 0;
                HandleOnDead(); //Player üzerindeki Health scriptine Canvas ı ver
            }
        }
    }



    public void TakeDamage(float _damage) //Hasar çarpanı ProjectileController scriptine bağlı
        {
            currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth); //Canın 0'ın altına düşmemesi ve max değere çıkmaması için bir koruma işlemi.
            currentHealth -= _damage;

            if (currentHealth > 0)
            {
                anim.SetTrigger("Hurt"); //yaralanma animasyonu devreye girecek

            }
            else
            {
                if (!_dead)
                {
                    anim.SetTrigger("Die"); //yaralanma animasyonu devreye girecek
                    _dead = true;
                   _isdead = _dead; //Gamemanager a gönderilecek ve oyuna restart özelliği verilecek
                }
            }
        }

    private void HandleOnDead()
    {
        gameOverPanel.SetActive(true);
    }
    }


