using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour 

{

    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}

// https://unity3d.com/learn/tutorials/topics/multiplayer-networking/player-health-single-player
