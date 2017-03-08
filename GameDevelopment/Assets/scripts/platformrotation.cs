using UnityEngine;
using System.Collections;

public class platformrotation : MonoBehaviour {
	//public float speed = 10f;

	//makes platform pivot
	public float pivotangle; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//sets spining platforms
		if (Input.GetKey (KeyCode.A)) { //rotates left
			pivotangle += 10;
		}
		if (Input.GetKey (KeyCode.D)) { //rotates right
			pivotangle -= 10;
		}

		pivotangle = (pivotangle + 360) % 360; //platform can rotate 360 degrees
		transform.rotation= Quaternion.Euler(new Vector3(0,0,pivotangle));
		}
	}