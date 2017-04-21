using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class stopDrums : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("armadillosong").GetComponent<AudioSource> ().Pause ();
	}
	
	// Update is called once per frame
	void Update () {
//		if (GameObject.Find ("armadillosong").GetComponent<AudioSource> ().isPlaying ());
//		{
//
//			
//		}
	}
}
