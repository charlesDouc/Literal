using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerLetter_Control : MonoBehaviour {

	Rigidbody2D theRigidBody;
	public GameObject theCam;

	// ------------------------------------------
	// Use this for initialization
	// ------------------------------------------
	void Start () {
		// Talk to the rigid body
		theRigidBody = GetComponent<Rigidbody2D> ();
		
	}

	// ------------------------------------------
	// Update is called once per frame
	// ------------------------------------------
	void Update () {
		if (theCam.transform.position.y < 0.5f) {
			// Activate the simulated
			theRigidBody.simulated = true;
		}

		// If an object fall
		if (transform.position.y < -15f) {
			// Add to the camera counter
			camera_tower cameraScript = theCam.GetComponent<camera_tower> ();
			cameraScript.addCounter ();
			// Destroy the object
			Destroy (gameObject);
		}
		
	}
}
