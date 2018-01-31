using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soda_controller : MonoBehaviour {

	public GameObject theCamera;

	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {

		
	}


	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {

		// Change the Drag when the object enters the liquid
		if (transform.position.y < -0.5f) {
			gameObject.GetComponent<Rigidbody2D> ().drag = 5f;
			
		}
	}

}
