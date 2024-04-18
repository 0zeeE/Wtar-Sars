using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    [SerializeField] PointHUD pointHUD;
    bool gamestopped = false;

    private void Start()
    {
        StartCoroutine(CountPoints());
    }

    public void StartGame()
    {

    }

    public void StopGame()
    {
        gamestopped = true;
    }
    private IEnumerator CountPoints()
    {
        
       while(!gamestopped)
        {
            pointHUD.Points += 5;

            yield return new WaitForSeconds(1);
        }
    }
}
