using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ThankYou : MonoBehaviour {

	Vector3 currentPos;

	public GameObject gameMaster;

	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		
	}

	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {
		currentPos = transform.position;

		// Start mouvement
		if (currentPos.y > 0) {
			currentPos.y -= 0.1f;
			transform.position = currentPos;
		} else {
			Invoke ("nextScene", 10f);
		}

		if (currentPos.y < -16f) {
			GM_Controller gmScript = gameMaster.GetComponent<GM_Controller> ();
			gmScript.loadFirst ();
		}
	}


	// --------------------------------------------
	// Functions
	// --------------------------------------------
	void nextScene () {
		currentPos.y -= 0.1f;
		transform.position = currentPos;
	}
}
