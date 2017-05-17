using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class loadlevel : MonoBehaviour {

    public void NextLevelButton(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void FreeMoneyButton()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
