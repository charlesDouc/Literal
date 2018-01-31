using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass_Controller : MonoBehaviour {


	Vector3 currentPos;
	Vector3 mousePos;

	Vector3 freezePos;
	bool clicked;

	int numberOfElementDestroyed;

	public GameObject theFloor;
	public GameObject gameMaster;


	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		// Desactivate the object at the begining of the scene
		gameObject.SetActive(false);

		clicked = false;
		numberOfElementDestroyed = 0;
	}


	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {
		currentPos = transform.position;



		// Link myPos to the value of the mouse on the screen
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		// Since it's 2D, keep the Z axis at 10f
		mousePos.z = 10f;

		// Follow the mouse position
		if (currentPos.x < mousePos.x) {
			currentPos.x += 0.3f;
		}
		if (currentPos.x > mousePos.x) {
			currentPos.x -= 0.3f;
		}
		// If the mass did go down, bring iot back up
		if (currentPos.y < -15.55f) {
			currentPos.y += 0.3f;
		}

		if (numberOfElementDestroyed == 7) {
			currentPos.y += 0.1f;
			floor_controller floorScript = theFloor.GetComponent<floor_controller> ();
			floorScript.goDown ();

			Invoke ("nextScene", 3f);
		}


		// Update the gameObject position on the xAxis
		if (!clicked) {
			transform.position = new Vector3 (currentPos.x, currentPos.y, 10f);
		}



		if (Input.GetMouseButtonDown (0) && !clicked) {
			// Capture the current value of transform.position
			freezePos = transform.position;
			clicked = !clicked;
		}

		// Trigger the animation
		if (clicked) {
			goDown ();
		}



	
	}


	// --------------------------------------------
	// Functions
	// --------------------------------------------
	void goDown() {
		// Move the mass on the y axis until it reach the floor
		if (transform.position.y > -26.95f) {
			freezePos.y -= 0.5f;
		} else {
			clicked = !clicked;
		}
		// Update position
		transform.position = new Vector3 (freezePos.x, freezePos.y, 10f);
	}

	// -------------------

	// Public function to update the number of destroyed element 
	public void objectDestroyed () {
		// Add one to the counter and tell it to the console
		numberOfElementDestroyed += 1;
		Debug.Log ("An object has been destroyed. New Count to : " + numberOfElementDestroyed);
	}

	// -------------------

	void nextScene() {
		GM_Controller gmScript = gameMaster.GetComponent<GM_Controller> ();
		gmScript.loadLiquid ();
	}

}
