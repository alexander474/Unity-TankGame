using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameraScript : MonoBehaviour {

    public Transform Player;

    public Camera FirstPersonCam;

    public Camera RearCam;

    void Start()
    {
        RearCam.gameObject.SetActive(false);
        FirstPersonCam.gameObject.SetActive(true);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            FirstPersonCam.gameObject.SetActive(false);
            RearCam.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            FirstPersonCam.gameObject.SetActive(true);
            RearCam.gameObject.SetActive(false);
        }

    }
}

// https://answers.unity.com/questions/1329439/switch-between-cameras-in-c.html