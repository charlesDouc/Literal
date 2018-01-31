using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_controller : MonoBehaviour {

	Vector3 currentPos;


	// --------------------------------------------
	// Use this for initialization
	// --------------------------------------------
	void Start () {
		currentPos = transform.position;
	}


	// --------------------------------------------
	// Update is called once per frame
	// --------------------------------------------
	void Update () {
		
	}



	public void goDown() {
		currentPos.y -= 0.2f;
		transform.position = currentPos;
	}
}
