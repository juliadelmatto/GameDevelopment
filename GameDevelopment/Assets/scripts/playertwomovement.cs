﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertwomovement : MonoBehaviour {

	public bool grounded; //checks if player is touching the ground
	public float xstart; //starting x position of ball
	public float ystart; //starting y position of ball
	public GameObject jumpparticles;
	public GameObject deathparticles;
	public GameObject partyparticles;
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

		if (Input.GetKey (KeyCode.UpArrow) && grounded == true) { //if player presses the up arrow
			transform.position = new Vector3 (transform.position.x + 0f, transform.position.y + 0f, 0); //jumps
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0f, 6f, 0f), ForceMode2D.Impulse);
			grounded = false; //dosen't jump while not touching the ground
			Instantiate (jumpparticles, transform.position, new Quaternion (0f, 0f, 0f, 0f));
			GameObject.Find("Jump4").GetComponent<AudioSource> ().Play (); //play jump sound
		}
		if (Input.GetKey (KeyCode.DownArrow)) { //if player presses the down arrow
			gameObject.GetComponent<Transform> ().position = new Vector3 (xstart, ystart, 0f);//resets ball from starting position
			GameObject.Find ("player2").GetComponent<Rigidbody2D>().velocity = new Vector3(0f,0f,0f);//sets velocity to zero so the ball dosent fall too fast
		}
	}
	//happens one frome when it touches trigger
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.root.gameObject.tag == "danger") {//spaws death particles
			Instantiate (deathparticles, transform.position, new Quaternion (0f, 0f, 0f, 0f));
		}
	}
	//happens multiple times
	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.tag == "partyplatform2") {//spawns confetti if player2 wins
			Instantiate (partyparticles, new Vector3(transform.position.x,transform.position.y,-1f), new Quaternion (0f, 0f, 0f, 0f));
		}
	}
	}