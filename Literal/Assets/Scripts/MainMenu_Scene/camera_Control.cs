using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_Control : MonoBehaviour {

	// Bool to activate the targeting
	public bool followLiteral;
	bool begin;

	// GameObject Variables
	public GameObject literal;
	public GameObject toBeActivated;

	// Float variable for the zoom value
	float zoom;



	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		zoom = 5;
		begin = true;
		followLiteral = true;
	}



	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {
		// Begin Animation
		if (transform.position.y > 1.14f && begin) {
			Vector3 currentPos = transform.position;
			currentPos.y -= 0.1f;
			transform.position = currentPos;
		} else {
			begin = false;
		}


		// If followLiteral is active, follow the gameObject transform
		if (followLiteral && !begin) {
			Vector3 pos = literal.transform.position;
			pos.z = 0f;
			pos.x = 0f;
			transform.position = pos;
		}

		// If the Camera reach a cetain y point
		if (transform.position.y < -23f) {
			// Stop following the object
			followLiteral = false;
			// Activate the Mass
			toBeActivated.SetActive (true);

			// Trigger the zoom animiation after 2s
			Invoke ("activateZoomOut", 2f);

		}

		// Adjust the camera zoom
		Camera.main.orthographicSize = zoom;
	}


	// --------------------------------------------
	// Functions
	// --------------------------------------------
	void activateZoomOut () {
		if (zoom < 14.10f) {
			zoom += 0.1f;
		}
	}






}
