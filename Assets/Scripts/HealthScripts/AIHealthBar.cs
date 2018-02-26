using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIHealthBar : MonoBehaviour {

    public Image healthBar;
    public float starthealth = 100;

    public bool aiIsDead = false;
    private float _currentHealth;

	// Use this for initialization
	void Start () {
        _currentHealth = starthealth;
    }
	
	// Update is called once per frame
	void Update () {
        if (_currentHealth <= 0)
        {
            dead();
            _currentHealth = 0;
        }
    }

    public void TakeDemage(float amount) {
        _currentHealth -= amount;

        healthBar.fillAmount = _currentHealth / starthealth;
        
    }

    void dead()
    {
        aiIsDead = true;
    }

}

//https://www.youtube.com/watch?v=UKs1qO8w7qc
