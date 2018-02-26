using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour {

    public AudioMixer audioMixer;

    public void GoBack()
    {
        Debug.Log("menu");
        SceneManager.LoadScene("Menu");
    }
    public void HowToPlay()
    {
        Debug.Log("HowToPlay");
        SceneManager.LoadScene("HowToPlay");
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
