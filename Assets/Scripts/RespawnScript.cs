using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script is from class with amazing razer
public class RespawnScript : MonoBehaviour {

    public Transform RespawnPoint;

        private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = RespawnPoint.position;
    }

}
