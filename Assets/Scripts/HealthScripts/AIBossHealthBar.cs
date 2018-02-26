using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AIBossHealthBar : MonoBehaviour {

    public Image AIBosshealthBar;
    public float starthealth = 300;


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

        AIBosshealthBar.fillAmount = currentHealth / starthealth;

        if(currentHealth <= 0)
        {
            dead();
        }
        Debug.Log("AIBOSS:        "+currentHealth);
    }

    void dead() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Bossdead");
    }

}
