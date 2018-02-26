using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour {
    public Text scoreText;

    PlayerHealthBar PHB;

    // Use this for initialization
    void Start () {
        PHB = FindObjectOfType<PlayerHealthBar>();
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = PHB.currentHealth.ToString() + "/" + PHB.starthealth.ToString();
    }
}
