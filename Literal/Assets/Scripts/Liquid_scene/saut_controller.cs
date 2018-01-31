using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saut_controller : MonoBehaviour {

	public Transform pivot;
	Vector3 RotAxis;
	float RotAngle;

	bool goDown;

	public Transform theCam;


	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		RotAxis = new Vector3 (0, 0, 1);
		goDown = false;
		RotAngle = 0f;
	}


	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {

		// If mouse button is hold, activate the bool
		if (Input.GetButton ("Fire1") && theCam.position.y < 20f) {
			goDown = true;
		} else {
			goDown = false;
		}


		// If the mouse is down, Start rotating the object
		if (goDown) {
			//Debug.Log (RotAngle);
			RotAngle -= 0.1f;
			transform.RotateAround (pivot.position, RotAxis, RotAngle); 
		} 

		// If the rotation access a certain point, kill the object
		if (RotAngle < -4.3f) {
			Destroy (gameObject);
		}


	}
}
