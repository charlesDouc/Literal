using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Spawn : MonoBehaviour {

	public GameObject waves;

	// -------------------------------------------
	// Use this for initialization
	// -------------------------------------------
	void Start () {
		
	}

	// -------------------------------------------
	// Update is called once per frame
	// -------------------------------------------
	void Update () {
		
	}

	// -------------------------------------------
	// Functions
	// -------------------------------------------
	public void SpawWave() {
		// Create a wave if the function is trigger
		GameObject wave = Instantiate (waves, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
	}


}
