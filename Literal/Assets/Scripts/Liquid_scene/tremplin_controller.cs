using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tremplin_controller : MonoBehaviour {

	public Transform theCam;
	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		
	}

	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {
		// If the camera goes beyond a certain point, destroy this object
		if (theCam.position.y < -11f) {
			Destroy (gameObject);
		}
		
	}
}
