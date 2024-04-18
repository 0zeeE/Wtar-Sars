using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerRunFix : MonoBehaviour
{
    private void start()
    {
        StartTheTime();
    }

    public void StartTheTime()
    {
        Time.timeScale = 1f;
    }
}
