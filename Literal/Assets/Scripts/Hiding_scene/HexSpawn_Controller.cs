using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexSpawn_Controller : MonoBehaviour {

	public Transform hex;



	// ---------------------------------------
	// Use this for initialization
	// ---------------------------------------
	void Start () {
		for (int i = 0; i < 60; i++) {
			Instantiate(hex, new Vector3(-1.5f, 0f, 0f), Quaternion.identity);
		}
		for (int i = 0; i < 60; i++) {
			Instantiate(hex, new Vector3(-3f, 0f, 0f), Quaternion.identity);
		}
		for (int i = 0; i < 60; i++) {
			Instantiate(hex, new Vector3(3f, 0f, 0f), Quaternion.identity);
		}
		for (int i = 0; i < 60; i++) {
			Instantiate(hex, new Vector3(1.5f, 0f, 0f), Quaternion.identity);
		}
		
	}

	// ---------------------------------------
	// Update is called once per frame
	// ---------------------------------------
	void Update () {
		
	}
}
