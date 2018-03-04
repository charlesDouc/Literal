using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Race : MonoBehaviour {

	bool followLiteral;
	bool readyForNext;
	public GameObject target;
	float zoom;

	public GameObject gameMaster;
	public Color nextBG;

	public GameObject thePole;

	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		followLiteral = false;
		zoom = 5;

		readyForNext = false;
	}

	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {
		// Camera movement at the begining to show the word
		if (transform.position.y > 2.73f) {
			Vector3 currentPos = transform.position;
			currentPos.y -= 0.1f;
			transform.position = currentPos;
		} else if (!readyForNext) {
			followLiteral = true;
			Pole_Controller poleScript = thePole.GetComponent<Pole_Controller>();
			poleScript.camReady();
		}

		// Avtivate the camera following
		if (followLiteral) {
			Vector3 Targetpos = target.transform.position;
			transform.position = new Vector3 (Targetpos.x, Targetpos.y, 0f);
		}

		// Change the zoom
		if (transform.position.x > 1f) {
			activateZoomOut ();
		}
		// Adjust the camera zoom
		Camera.main.orthographicSize = zoom;

		// When the letter C reach the finish line
		if (transform.position.x > 157f) {
			// Change bg color
			Camera.main.backgroundColor = nextBG;
			// Stop all movement
			readyForNext = true;
			followLiteral = false;

			Invoke ("rollToNext", 3f);

		}

		if (transform.position.x > 200f) {
			GM_Controller gmScript = gameMaster.GetComponent<GM_Controller> ();
			gmScript.loadHiding ();
		}




	}


	// --------------------------------------------
	// Functions
	// --------------------------------------------
	void activateZoomOut () {
		if (zoom < 14.10f) {
			zoom += 0.1f;
		}
	}

	void rollToNext () {
		Vector3 currentPos = transform.position;
		currentPos.x +=  0.3f;
		transform.position = currentPos;
	}
}
