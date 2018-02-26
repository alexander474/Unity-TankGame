using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour {
    public float BarrelSpeed = 5.0f;
    //public float maxrotation = -30.0f; 
    //public float minrotation = -3;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        BarrelRotate();
	}

    private void BarrelRotate()
    {
        float rotateBarrel = BarrelSpeed * Time.deltaTime;

        // Make the barrel go up and down
        if (Input.GetKey(KeyCode.Alpha2)) //go up
        {
       
                transform.Rotate(-rotateBarrel, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Alpha1)) //go down
        {
                transform.Rotate(rotateBarrel, 0f, 0f);
        }
    }
}
