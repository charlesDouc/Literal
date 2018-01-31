using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbles_controller : MonoBehaviour {

	float size;

	// -------------------------------------------
	// Use this for initialization
	// -------------------------------------------
	void Start () {
		size = Random.Range (0.05f, 0.5f);
		transform.localScale = new Vector3 (size, size, size);
	}

	// -------------------------------------------
	// Update is called once per frame
	// -------------------------------------------
	void Update () {

		if (transform.position.y > 0) {
			Destroy (gameObject);
		}
		
	}
}
