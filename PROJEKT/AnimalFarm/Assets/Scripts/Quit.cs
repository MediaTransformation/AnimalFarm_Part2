using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Beenden der Pc-Application über ESC-Taste.
/// </summary>
public class Quit : MonoBehaviour {
	
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
