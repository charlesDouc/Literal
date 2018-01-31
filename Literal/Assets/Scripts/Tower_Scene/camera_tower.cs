using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_tower : MonoBehaviour {

	Vector3 currentPos;
	int counter;

	public GameObject gameMaster;
	public Color nextBG;

	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		counter = 0;
		
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
		}

		// If falling, destroy the floor and change bg color
		if (counter == 25) {
			Camera.main.backgroundColor = nextBG;
			// Camera mouvement
			Invoke ("nextScene", 2f);
			// At a certain point, load next scene
			if (transform.position.y < -15f) {
				GM_Controller gmScript = gameMaster.GetComponent<GM_Controller> ();
				gmScript.loadThanks ();
			}

		}
			
			
		
	}


	// --------------------------------------------
	// Functions
	// --------------------------------------------
	public void addCounter () {
		counter += 1;
		Debug.Log ("Number of elemet destroyed : " + counter);
	}

	void nextScene () {
		currentPos.y -= 0.1f;
		transform.position = currentPos;
	}

}
