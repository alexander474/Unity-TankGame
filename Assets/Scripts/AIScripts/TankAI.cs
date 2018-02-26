using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAI : MonoBehaviour {

    Animator anim;
    public GameObject player;

    TankAiShooting tas;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
        tas = GetComponentInChildren<TankAiShooting>();
        anim.SetFloat("distance", Vector3.Distance(transform.position, player.transform.position));
    }

    public GameObject GetPlayer()
    {
       return player = GameObject.Find("T95-1");
    }

    void Fire()
    {
        tas.shoot();
    }

    public void StartFiring()
    {
        InvokeRepeating("Fire", 0.5f, 0.8f);
    }

    public void StopFiring()
    {
        CancelInvoke("Fire");
    }
	
	// Update is called once per frame
	void Update () {

        anim.SetFloat("distance", Vector3.Distance(transform.position, player.transform.position));

	}
}
