using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Settings()
    {
        Debug.Log("Settings");
        SceneManager.LoadScene("Settings");
    }
    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
