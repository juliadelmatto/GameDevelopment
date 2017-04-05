using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X")<0){
			//Code for action on mouse moving left
			print("Mouse moved left");
		}
		if(Input.GetAxis("Mouse X")>0){
			//Code for action on mouse moving right
			print("Mouse moved right");
		}
	}
}
