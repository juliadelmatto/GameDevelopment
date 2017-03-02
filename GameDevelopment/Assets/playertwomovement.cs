using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertwomovement : MonoBehaviour {

	public bool grounded;
	public float xstart;
	public float ystart;
	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "platform") { //player must be on platform to jump
			grounded = true;
		}

	}
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow) && grounded == true) {
			transform.position = new Vector3 (transform.position.x + 0f, transform.position.y + 0f, 0);
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0f, 6f, 0f), ForceMode2D.Impulse);
			grounded = false;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.GetComponent<Transform> ().position = new Vector3 (xstart, ystart, 0f);
		}
	}
}
