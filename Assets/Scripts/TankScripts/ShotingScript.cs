using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotingScript : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed = 60f;
    public float timeBetweenShots = 0.333f;
    private float _timestamp;


    public void Update()
    {

        if (Input.GetButton("Fire1") && Time.time >= _timestamp)
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                           transform.position,
                                                           transform.rotation)
                as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            Destroy(instantiatedProjectile.gameObject, 5);
            _timestamp = Time.time + timeBetweenShots;
        }

    }
}

// Shoting part of script got tips from: https://forum.unity.com/threads/gun-shooting-script-c.222057/
// bullet delay part of script is from: https://answers.unity.com/questions/665352/shot-delay-between-button-press-c.html
