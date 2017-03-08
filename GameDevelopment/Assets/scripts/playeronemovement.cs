using UnityEngine;
using System.Collections;

public class playeronemovement : MonoBehaviour {

	public bool grounded; //checks if ball is touching the ground
	public float xstart; //x starting position of ball
	public float ystart; //y starting position of ball

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
		if (Input.GetKey (KeyCode.W)&& grounded==true) {
			transform.position = new Vector3 (transform.position.x + 0f, transform.position.y + 0f, 0);
			this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f,6f,0f), ForceMode2D.Impulse);//sets how high the jump is
			grounded = false;
		
		}
		if (Input.GetKey (KeyCode.S)){
			gameObject.GetComponent<Transform> ().position = new Vector3 (xstart, ystart, 0f);
			GameObject.Find ("player1").GetComponent<Rigidbody2D>().velocity = new Vector3(0f,0f,0f);
		}
	}
}
	