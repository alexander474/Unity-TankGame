using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{

    public Image healthBar;
    public float starthealth = 200;


    public float currentHealth;

    // Use this for initialization
    void Start()
    {
        currentHealth = starthealth;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TakeDemage(float amount)
    {
        currentHealth -= amount;

        healthBar.fillAmount = currentHealth / starthealth;
    }

}

//https://www.youtube.com/watch?v=UKs1qO8w7qc
