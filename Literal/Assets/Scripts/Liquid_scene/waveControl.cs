using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveControl : MonoBehaviour {

	Vector3 currentPos;

	public GameObject theSpawner;
	bool spawOnce;

	// To know if they are not on screen when scene is lauch
	public bool isAtStart;


	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		currentPos = transform.position;
		spawOnce = true;
	}


	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {
		// Add a movement on the x axix
		currentPos.x += 0.1f;
		transform.position = currentPos;

		// If the object pass a certain point, trigger the wave spaning function
		if (transform.position.x > -20.6f && spawOnce && !isAtStart) {
			Wave_Spawn waveSpawnScript = theSpawner.GetComponent<Wave_Spawn> ();
			waveSpawnScript.SpawWave();
			// Do it only once
			spawOnce = !spawOnce;
		}

		// If the object goes out of the camera, kill it
		if (transform.position.x > 30f) {
			Destroy (gameObject);
		}
	}
}
