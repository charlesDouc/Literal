using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_hides : MonoBehaviour {

	Vector3 currentPos;
	public Transform letter1;
	public Transform letter2;
	public Transform letter3;
	public Transform letter4;
	public Transform letter5;
	public Transform letter6;

	public GameObject theFloor;

	bool falling;

	public Color nextBG;

	public GameObject gameMaster;

	// ------------------------------------------
	// Use this for initialization
	// ------------------------------------------
	void Start () {
		falling = false;
	}

	// ------------------------------------------
	// Update is called once per frame
	// ------------------------------------------
	void Update () {
		currentPos = transform.position;

		// Start mouvement
		if (currentPos.x < 0) {
			currentPos.x += 0.3f;
			transform.position = currentPos;
		}

		// Check if a letter pass the dotted line
		if (letter1.position.y < -3f ||
			letter2.position.y < -3f ||
			letter3.position.y < -3f ||
			letter4.position.y < -3f ||
			letter5.position.y < -3f ||
			letter6.position.y < -3f &&
			!falling) {
			falling = !falling;
		}

		// If falling, destroy the floor and change bg color
		if (falling) {
			Destroy (theFloor);
			Camera.main.backgroundColor = nextBG;
			// Camera mouvement
			Invoke ("nextScene", 4f);

			// At a certain point, load next scene
			if (transform.position.y < -20f) {
				GM_Controller gmScript = gameMaster.GetComponent<GM_Controller> ();
				gmScript.loadTower ();
			}
		}
			

	}


	// ------------------------------------------
	// Function
	// ------------------------------------------
	void nextScene () {
		currentPos.y -= 0.3f;
		transform.position = currentPos;
	}

}
