using UnityEngine;
using System.Collections;

public class platformsidemovement : MonoBehaviour {
	
	public float xleftamount; //how much platforms move left
	public float xrightamount;//how much platforms move right
	public float startxpos;//starting position of platforms
	public float leftdifference;//amount platform has moved left
	public float rightdifference; //amount platform has moved right
	Rigidbody2D platformrb;// platform rigidbody

	bool lefttrue;
	bool righttrue;

	// Use this for initialization
	void Start () {
		platformrb = GetComponent<Rigidbody2D> ();
		startxpos = transform.position.x;
		leftdifference = startxpos - xleftamount;//calculate difference between starting position and where it is
		rightdifference = startxpos + xrightamount;
		platformrb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		



		//sets platform sliding movement
		if (Input.GetKey (KeyCode.A)) {
			platformrb.velocity = new Vector3 (-4f, 0f, 0f);
			lefttrue = true;
			//transform.position = new Vector3 (transform.position.x - 0.1f, transform.position.y, 0f)
		}
		if (Input.GetKeyUp (KeyCode.A)){
			platformrb.velocity = new Vector3 (0f,0f,0f);
			lefttrue = false;
		}
		if (Input.GetKey (KeyCode.D)) {
			platformrb.velocity = new Vector3 (4f, 0f, 0f);

			righttrue = true;
			//transform.position = new Vector3 (transform.position.x + 0.1f, transform.position.y, 0f);
		}
		if (Input.GetKeyUp (KeyCode.D)){
				platformrb.velocity = new Vector3 (0f,0f,0f);
			righttrue = false;
			}

		if (transform.position.x <= leftdifference && lefttrue == true && righttrue == false) {//stops platform from moving too far
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
		}

		if (transform.position.x >= rightdifference && righttrue == true && lefttrue == false) {//stops platform from moving too far
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
		}

	}


}


