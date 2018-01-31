using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCollider_Controller : MonoBehaviour {

	Vector3 pos;

	// ---------------------------------------
	// Use this for initialization
	// ---------------------------------------
	void Start () {
		
	}

	// ---------------------------------------
	// Update is called once per frame
	// ---------------------------------------
	void Update () {
		pos = Input.mousePosition;
		pos.z = 10f;

		this.transform.position = Camera.main.ScreenToWorldPoint(pos);
		
	}
}
