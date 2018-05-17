using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnter : MonoBehaviour {

	public static int colliderReady;

		void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Enter")
        {
            colliderReady = 1;
			print("Enter");

        } else if (collider.gameObject.tag == "Exit") {
			colliderReady = 2;
			print("Exit");
		} 
    }
}
