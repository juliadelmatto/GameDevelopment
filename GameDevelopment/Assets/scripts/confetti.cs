//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class confetti : MonoBehaviour {
//	public GameObject party;
//
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
//	void OnTriggerEnter2D(Collider2D other){
//		if (other.transform.root.gameObject.tag == "danger") {
//			print ("hey");
//			Instantiate (party, transform.position, new Quaternion (0f, 0f, 0f, 0f));
//		}
//	}
//}
using UnityEngine;
using System.Collections;

public class confetti : MonoBehaviour {

	public bool grounded; //checks if ball is touching the ground
	public float xstart; //x starting position of ball
	public float ystart; //y starting position of ball
	public GameObject jumpparticles;
	public GameObject deathparticles;
	public GameObject party;

	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter2D (Collision2D col)
	{
		//makes it so player can only jump once, they can only jump if they were on an object tagged platform
		if (col.gameObject.tag == "platform") {
			grounded = true;
		}

	}
	// Update is called once per frame
	void Update () {
		//player one jump
		if (Input.GetKey (KeyCode.W)&& grounded==true) { //if player presses W

			transform.position = new Vector3 (transform.position.x + 0f, transform.position.y + 0f, 0); //ball jumps
			this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f,6f,0f), ForceMode2D.Impulse);//sets how high the jump is
			grounded = false; //ball cant jump while not touching the ground
			Instantiate (jumpparticles, transform.position, new Quaternion (0f, 0f, 0f, 0f));
			GameObject.Find("Jump4").GetComponent<AudioSource> ().Play (); //play jump sound
		}

		if (Input.GetKey (KeyCode.S)){ //if player presses S
			gameObject.GetComponent<Transform> ().position = new Vector3 (xstart, ystart, 0f); //resets ball from start
			GameObject.Find ("player1").GetComponent<Rigidbody2D>().velocity = new Vector3(0f,0f,0f); //sets velocity to zero so the ball dosent fall too fast
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.root.gameObject.tag == "platform") {
			Instantiate (party, transform.position, new Quaternion (0f, 0f, 0f, 0f));
		}

	}
}

