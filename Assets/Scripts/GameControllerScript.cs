using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameControllerScript : MonoBehaviour {

   private int _point = 0;

   

    // Use this for initialization
    void Start () {
        
    }
    
    public void PlayerHitAi() {
        _point += 10;
    }

    // Update is called once per frame
    void OnGUI() {
        Rect points = new Rect(Screen.width - 120, Screen.height - 100, 100, 30);
        GUI.Box(points, "Points: " + _point.ToString());
    }
}
