using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keep : MonoBehaviour {

	//public Text score1;


	//keeps the score between scenes
	void Awake() {
		//keep game object between scenes
		DontDestroyOnLoad(transform.gameObject);
	}
	// Use this for initialization
	void Start ()
	{
		//if (!GameObject.Find("player1score")){
		//Instantiate(score1);

	}
	
	// Update is called once per frame
	void Update () {



	}



}
