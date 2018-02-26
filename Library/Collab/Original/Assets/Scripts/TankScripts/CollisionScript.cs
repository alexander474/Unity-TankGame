using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Transform explosionPrefab;
    GameControllerScript gcs;
    AIHealthBar AIHB;

    private void Start()
    {
        gcs = FindObjectOfType<GameControllerScript>();
        AIHB = FindObjectOfType<AIHealthBar>();
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject collidedWith = collision.gameObject;

        if (collidedWith.tag == "NPC")
        {
            Debug.Log("Enemy Hit");
            gcs.PlayerHitAi();
            AIHB.TakeDemage(20);
            Instantiate(explosionPrefab, pos, rot);
            Destroy(gameObject);

        }

        
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);
    }

    /*private void OnCollisionEnter (Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);
    }*/
}