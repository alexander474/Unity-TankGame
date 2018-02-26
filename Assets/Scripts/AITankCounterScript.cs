using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AITankCounterScript : MonoBehaviour {
    public Text TankCounterText;
    GameObject[] enemyUnits;

    public int TankCounter;

    AISpawning AIS;

    public void OneKilled() {
        TankCounter -= 1;
    }

	// Use this for initialization
	void Start () {
        enemyUnits = GameObject.FindGameObjectsWithTag("enemy");
        TankCounter = enemyUnits.Length;
        AIS = FindObjectOfType<AISpawning>();
    }
	
	// Update is called once per frame
	void Update () {
        TankCounterText.text = TankCounter.ToString() + "/" + enemyUnits.Length.ToString();
        Winning();
    }

    void Winning()
    {
        if (TankCounter <= 0)
        {
            AIS.allTanksKilled = true;
            AIS.SpawnBoss();
        }
    }
}
