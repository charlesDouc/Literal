using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble_spawn : MonoBehaviour {

	bool spawning;
	bool canSpawn;
	public GameObject bubbles;
	public Transform theCam;

	// -------------------------------------------
	// Use this for initialization
	// -------------------------------------------
	void Start () {
		spawning = false;
		canSpawn = false;
	}


	// -------------------------------------------
	// Update is called once per frame
	// -------------------------------------------
	void Update () {




		if (Input.GetButton ("Fire1")) {
			spawning = true;
		} else {
			spawning = false;
		}


		if (spawning && canSpawn) {
			Vector3 currentPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			currentPos.z = 10f;

			GameObject bubble = Instantiate (bubbles, currentPos, Quaternion.Euler(new Vector3(0, 0, 0)));
			bubble.transform.parent = gameObject.transform;
		}

		if (theCam.position.y < -11f && !canSpawn) {
			canSpawn = !canSpawn;
		}
		
	}
}
