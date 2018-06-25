using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Ready");
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.JoystickButton0))
            
        {
            print("Action");
        }
		
	}
}
