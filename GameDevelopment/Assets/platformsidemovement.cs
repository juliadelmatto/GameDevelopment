using UnityEngine;
using System.Collections;

public class platformsidemovement : MonoBehaviour {
	
	public float xleftamount;
	public float xrightamount;
	public float startxpos;
	public float leftdifference;
	public float rightdifference;
	Rigidbody2D platformrb;

	bool lefttrue;
	bool righttrue;

	// Use this for initialization
	void Start () {
		platformrb = GetComponent<Rigidbody2D> ();
		startxpos = transform.position.x;
		leftdifference = startxpos - xleftamount;
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

		if (transform.position.x <= leftdifference && lefttrue == true && righttrue == false) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
		}

		if (transform.position.x >= rightdifference && righttrue == true && lefttrue == false) {
			platformrb.velocity = new Vector3 (0f, 0f, 0f);
		}

	}


}


