using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningSceneScript : MonoBehaviour {

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
