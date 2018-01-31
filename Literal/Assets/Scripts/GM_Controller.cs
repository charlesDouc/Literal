using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM_Controller : MonoBehaviour {



	// ------------------------------------------
	// Use this for initialization
	// ------------------------------------------
	void Start () {
		Cursor.visible =true;
		
	}

	// -----------------------------------------
	// Update is called once per frame
	// -----------------------------------------
	void Update () {
		// Let the user quit easily the application
		if (Input.GetKey("escape")) {
			Application.Quit();
		}
		
	}


	// -----------------------------------------
	// Function
	// -----------------------------------------
	public void loadLiquid() {
		SceneManager.LoadScene ("liquid");
	}
	public void loadRace() {
		SceneManager.LoadScene ("race");
	}
	public void loadHiding() {
		SceneManager.LoadScene ("hides");
	}
	public void loadTower() {
		SceneManager.LoadScene ("tower");
	}
	public void loadThanks() {
		SceneManager.LoadScene ("thanks");
	}
	public void loadFirst() {
		SceneManager.LoadScene ("first");
	}


}
