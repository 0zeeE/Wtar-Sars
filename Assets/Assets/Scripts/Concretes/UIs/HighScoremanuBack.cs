using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoremanuBack : MonoBehaviour
{
    public void Bakcbutton()
    {
        //SceneManager.LoadScene(0);
        SceneManager.LoadSceneAsync("Mainmenu");
    }
}
