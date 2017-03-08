using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	

	public Text time;
	public float timeleft = 4;
	public float xpos;
	public float ypos;
	public float p2xpos;
	public float p2ypos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
		//timeleft--;
		//if (timeleft ==1)
		//{
		//time.ToString =="Go"
		//}
		time.text = timeleft.ToString ();
		if (timeleft <= 0) {
			time.text = "" + 0;
			//yield return new WaitForSeconds (1);
			time.transform.gameObject.SetActive (false);
		} 
		if (timeleft <= 1) {
			time.text = "GO!";
		}

		else {
			time.text = Mathf.Round (timeleft).ToString ();

		}
	

		if (timeleft > 0) {
			GameObject.Find ("player1").transform.position = new Vector3 (xpos, ypos, 0f);
			GameObject.Find ("player2").transform.position = new Vector3 (p2xpos, p2ypos, 0f);
			GameObject.Find ("player1").GetComponent<Rigidbody2D>().velocity = new Vector3(0f,0f,0f);
			GameObject.Find ("player2").GetComponent<Rigidbody2D>().velocity = new Vector3(0f,0f,0f);
		}
	
	
	}
}
