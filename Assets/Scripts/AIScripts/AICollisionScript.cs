using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AICollisionScript : MonoBehaviour
{
    public Transform explosionPrefab;
    public float TakeDemage = 20;
    PlayerHealthBar PHB;

    private void Start()
    {
        PHB = FindObjectOfType<PlayerHealthBar>();

    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        GameObject collidedWith = collision.gameObject;

        if (collidedWith.tag == "player")
        {
            Instantiate(explosionPrefab, pos, rot);
            PHB.TakeDemage(TakeDemage);
            Destroy(gameObject);
            if (PHB.currentHealth <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);
    }
}