using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public Transform explosionPrefab;
    public float TakeDemage = 20;
    public string unitName;


    GameControllerScript gcs;
    AIHealthBar AIHB;
    AITankCounterScript AITCS;
    AIBossHealthBar AIBHB;

    private void Start()
    {
        gcs = FindObjectOfType<GameControllerScript>();
        AITCS = FindObjectOfType<AITankCounterScript>();
        AIBHB = FindObjectOfType<AIBossHealthBar>();
        AIHB = FindObjectOfType<AIHealthBar>();
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject collidedWith = collision.gameObject;
        unitName = collidedWith.tag;
        AIHB = collidedWith.GetComponentInChildren<AIHealthBar>();

        if (unitName.Contains("UNIT") && collidedWith != null)
        {
            gcs.PlayerHitAi();
            if (AITCS.TankCounter >= 1)
                AIHB.TakeDemage(TakeDemage);
            if (collidedWith.tag == "UNIT-BOSS")
                AIBHB.TakeDemage(TakeDemage);
            Instantiate(explosionPrefab, pos, rot);
            Destroy(gameObject);
            //Destroy(gameObject);
            if (AIHB.aiIsDead == true)
            {
                AITCS.OneKilled();
                Destroy(collidedWith);
            }
            //if(AIBHB.health <= 0) {
              //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //}
        }
       
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);

        if(unitName.Contains("House"))
        {
            Destroy(collidedWith);
            Destroy(gameObject);
        }

    }

}