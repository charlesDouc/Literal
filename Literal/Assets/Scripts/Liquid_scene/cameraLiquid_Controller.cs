using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLiquid_Controller : MonoBehaviour {

	public GameObject sodaObject;
	bool breakPoint;
	bool readyForNext;
	bool stopFollowing;
	Camera thisCam;

	public Color nextBg;
	public GameObject gameMaster;

	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		breakPoint = false;
		readyForNext = false;
		stopFollowing = false;
		thisCam = GetComponent<Camera> ();
	}


	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {

		if (transform.position.y > 20 ) {
			Vector3 currentPos = transform.position;
			currentPos.y -= 0.1f;
			transform.position = currentPos;
		} else if (!stopFollowing)  {
			// If the following is trigger, follow the pos of sodaObject
			Vector3 pos = sodaObject.transform.position;
			Vector3 currentPos = transform.position;
			pos.z = 0f;
			// Bring the camera on the x axis
			if (currentPos.x < pos.x && breakPoint) {
				currentPos.x += 0.01f;
			}
			// Bring the camera on the x axis
			if (currentPos.x > pos.x && breakPoint) {
				currentPos.x -= 0.01f;
			}
			//	Update the position of the camera
			transform.position = new Vector3 (currentPos.x, pos.y + 1.85f, pos.z);;
		}

		// Activatee the breakPoint
		if (transform.position.y < -0.5f) {
			breakPoint = true;
		}
		// Activate the sequence for the next scene
		if (transform.position.y < -11f && !readyForNext) {
			readyForNext = !readyForNext;
		}

		// Sequence for the next scene
		if (readyForNext) {
			// Change the color BG
			thisCam.backgroundColor = nextBg;

			if (transform.position.y > -0.5f) {
				stopFollowing = true;
				Vector3 currentPos = transform.position;
				currentPos.y += 0.05f;
				transform.position = currentPos;
				Invoke ("nextScene", 4f);

			}
		}
			

	}


	// --------------------------------------------
	// Functions
	// --------------------------------------------
	void nextScene () {
		GM_Controller gmScript = gameMaster.GetComponent<GM_Controller> ();
		gmScript.loadRace ();
	}
}
