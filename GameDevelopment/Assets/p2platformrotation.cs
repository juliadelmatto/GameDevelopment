using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2platformrotation : MonoBehaviour {

	//makes platform pivot
	public float pivotangle; 


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//if (Input.GetKey (KeyCode.A)) {
		//transform.Rotate (Vector3.up, speed * Time.deltaTime);

		//player two rotation
		if (Input.GetKey (KeyCode.LeftArrow)) {
			pivotangle += 10;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			pivotangle -= 10;
		}

		pivotangle = (pivotangle + 360) % 360;
		transform.rotation= Quaternion.Euler(new Vector3(0,0,pivotangle));
	}
}