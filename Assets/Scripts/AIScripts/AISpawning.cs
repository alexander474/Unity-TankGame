using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawning : MonoBehaviour
{
    public GameObject Boss;


    bool isBossSpawned = false;
    public bool allTanksKilled = false;

    private void Update()
    {
        SpawnBoss();
    }

    public void SpawnBoss()
    {

        if (!isBossSpawned && allTanksKilled) {
            Instantiate(Boss);
            isBossSpawned = true;
        }
    }

}
