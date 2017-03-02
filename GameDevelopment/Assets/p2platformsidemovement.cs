using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2platformsidemovement : MonoBehaviour {
	
	public float xleftamount;
	public float xrightamount;
	public float startxpos;
	public float leftdifference;
	public float rightdifference;
	Rigidbody2D platformrb;


	bool lefttrue;
	bool righttrue;

	void Start () {
		platformrb = GetComponent<Rigidbody2D> ();
		startxpos = transform.position.x;
		leftdifference = startxpos - xleftamount;
		rightdifference = startxpos + xrightamount;
		platformrb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			platformrb.velocity = new Vector3 (-4f, 0f, 0f);
			lefttrue = true;
			//transform.position = new Vector3 (transform.position.x - 0.1f, transform.position.y, 0f)
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
			lefttrue = false;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			platformrb.velocity = new Vector3 (4f, 0f, 0f);

			righttrue = true;
			//transform.position = new Vector3 (transform.position.x + 0.1f, transform.position.y, 0f);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
			righttrue = false;
		}

		if (transform.position.x <= leftdifference && lefttrue == true && righttrue == false) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
			Debug.Log ("whats up");
		}

		if (transform.position.x >= rightdifference && righttrue == true && lefttrue == false) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
		}


	}
}
