using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace StarDucks.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.startGame();
            
        }

        public void NoButtonClick()
        {
            SceneManager.LoadScene(0);                                                     //no dersek skoru kaydetmeyecek 
        }
    }
}
