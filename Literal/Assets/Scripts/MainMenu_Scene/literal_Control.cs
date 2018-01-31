using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class literal_Control : MonoBehaviour {


	Rigidbody2D theRigidBody;
	float roationAngle;

	public GameObject ignore;
	public GameObject massObject;


	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		// Talk to the rigidbody 2d
		theRigidBody = GetComponent<Rigidbody2D>();



	}

	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {

		// If the Enter key is pressed, activate the physic on object
		if (Input.GetMouseButtonDown(0)) {
			//Debug.Log("PRESSED");
			theRigidBody.simulated = true;
			roationAngle = Random.Range(-2, 2);
		}

		// When the physic is activated, start rotating on the Z axis
		if (theRigidBody.simulated && transform.position.y > -21f) {
			//Debug.Log ("Physic is on");
			transform.Rotate (0f, 0f, roationAngle);
		}

		// If the object reach a certain point, destroy it
		if (transform.position.y < -35f) {
			// Before destroying the object, access the counter of the mass and add value to it
			Mass_Controller massScript = massObject.GetComponent<Mass_Controller> ();
			massScript.objectDestroyed ();
			Destroy (gameObject);
		}

	}



	// --------------------------------------------
	// Functions
	// --------------------------------------------
	void OnCollisionEnter2D (Collision2D coll) {
		// If the object is hit by the mass, ignore the floor so they fall
		if (coll.gameObject.name == "Mass") {
			Physics2D.IgnoreCollision (ignore.GetComponent<Collider2D>(), GetComponent<Collider2D> ());
		}
	}




}
