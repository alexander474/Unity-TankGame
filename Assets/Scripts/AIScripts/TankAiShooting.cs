using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAiShooting : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed = 30;



    public void shoot()
    {
            Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                           transform.position,
                                                           transform.rotation)
                as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            Destroy(instantiatedProjectile.gameObject, 5);
    }
}

// Shoting part of script got tips from: https://forum.unity.com/threads/gun-shooting-script-c.222057/
// bullet delay part of script is from: https://answers.unity.com/questions/665352/shot-delay-between-button-press-c.html
