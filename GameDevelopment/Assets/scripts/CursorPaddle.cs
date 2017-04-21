using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPaddle : MonoBehaviour {

	float zAxis = 2f;
	Vector3 mousePosition;

	 //Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = 
			Camera.main.ScreenToWorldPoint (Input.mousePosition);
		temp.z = 5f;
		transform.position = temp;
	}

	public void destroyCursor(){
		Destroy (this.gameObject);
	}
}

	