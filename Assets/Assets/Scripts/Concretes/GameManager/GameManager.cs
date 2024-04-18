using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    [SerializeField] int score;
    public static GameManager Instance {get; private set;}

    public event System.Action<int> OnScoreChanged;
    
    void Start()
    {
        
    }

    private void Awake()
    {
        SingletonThisGameObject();
        
    }

    
    void Update()
    {
        
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null) //Oyun hiyerarşisi içerisinde 1 tane GameManager Instance olmasını istiyorum
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    //Hp sistemine göre öldükten sonra oyunu yeniden başlatmak için kullanılacak.
    public void startGame() 
    {
        score = 0; //gecici olarak skoru sıfırladım. Database gelince değişecek 
        Time.timeScale = 1f; //Zamanı tekrardan akışa vermek için koyuldu
        //StartCoroutine(startGameAsync());

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private IEnumerator startGameAsync() //Değiştirilecek.
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }

    public void IncreaseScore()
    {
        score+= 10;
        OnScoreChanged?.Invoke(score);
        /* Uzun yazımı
         if(OnScoreChanged != null)
        {
            OnscoreChanged();
        }
         */
    }
}
