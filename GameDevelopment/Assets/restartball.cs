using UnityEngine;
using System.Collections;

public class restartball : MonoBehaviour {

	//sets the restart locations, because it is different in every level
	public float xstart;
	public float ystart;
	public float p2xstart;
	public float p2ystart;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	//makes player one restart
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.root.gameObject.name == "player1"){
			other.gameObject.GetComponent<Transform> ().position = new Vector3 (xstart, ystart, 0f); //restarts ball from its starting point
			other.gameObject.GetComponent<Rigidbody2D >().velocity = new Vector3(0f,0f,0f); //resets velocity of ball
		}
		//makes player two restart
		if (other.transform.root.gameObject.name == "player2"){ 
			other.gameObject.GetComponent<Transform> ().position = new Vector3 (p2xstart, p2ystart, 0f); //restarts ball from its starting point
			other.gameObject.GetComponent<Rigidbody2D >().velocity = new Vector3(0f,0f,0f); //resets velocity of ball
		}

}
}


