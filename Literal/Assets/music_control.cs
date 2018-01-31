using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_control : MonoBehaviour {
	
	static bool AudioBegin = false;
	public AudioClip music;

	// ------------------------------------
	// Use this for initialization
	// ------------------------------------
	void Awake () {
		AudioSource audio = GetComponent<AudioSource> ();

		if (!AudioBegin) {
			audio.clip = music;
			audio.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
