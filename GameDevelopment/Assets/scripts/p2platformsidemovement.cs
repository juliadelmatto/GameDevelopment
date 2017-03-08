using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2platformsidemovement : MonoBehaviour {
	
	public float xleftamount; //how much platforms move left
	public float xrightamount; //how much platforms move right
	public float startxpos; //starting position of platforms
	public float leftdifference; //amount platform has moved left
	public float rightdifference; //amount platform has moved right
	Rigidbody2D platformrb; // platform rigidbody


	bool lefttrue; //when platform reaches a certain point bool becomes false and stops platform
	bool righttrue;

	void Start () {
		platformrb = GetComponent<Rigidbody2D> ();
		startxpos = transform.position.x;
		leftdifference = startxpos - xleftamount; //calculate difference between starting position and where it is
		rightdifference = startxpos + xrightamount; //calculate difference between starting position and where it is
		platformrb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			platformrb.velocity = new Vector3 (-4f, 0f, 0f);
			lefttrue = true;

		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
			lefttrue = false;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			platformrb.velocity = new Vector3 (4f, 0f, 0f);

			righttrue = true;

		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
			righttrue = false;
		}

		if (transform.position.x <= leftdifference && lefttrue == true && righttrue == false) { //stops platform from moving too far
			platformrb.velocity = new Vector3 (0f, 0f, 0f);

		}

		if (transform.position.x >= rightdifference && righttrue == true && lefttrue == false) { //stops platform from moving too far
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
		}


	}
}
