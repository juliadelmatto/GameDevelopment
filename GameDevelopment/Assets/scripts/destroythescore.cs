using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroythescore : MonoBehaviour {

	//set scores
	public Text Score;
	public Text Score2;

	// Use this for initialization
	void Start () {
		//automatically assigns scores in inspector
		Score = GameObject.Find("player1score").GetComponent<Text>();
		Score2 = GameObject.Find("player2score").GetComponent<Text>();


		GameObject.Find("player1score").GetComponent<Text>().text = "0";
		GameObject.Find("player2score").GetComponent<Text>().text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		//destroy scores

	}
}
