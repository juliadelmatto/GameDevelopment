using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishline : MonoBehaviour {

	//set score
	public static int MyScore; //score1
	public Text MyScoreDisplay; //scoredisplay
	public static int MyScore2; //score2
	public Text MyScoreDisplay2; //scoredisplay2
	public string scenename; //set next scene

	// Use this for initialization



	void Start () {
		//automatically sets the score in inspectory so it will display every level
		MyScoreDisplay = GameObject.Find("player1score").GetComponent<Text>();
		MyScoreDisplay2 = GameObject.Find("player2score").GetComponent<Text>();
	
	}

	// Update is called once per frame
	void Update () {

	}
	//when the finishline collides with either player, their score will increase, and the level will change
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.root.gameObject.name == "player1"){
		 //play win sound
		MyScore++;//increases score
		Debug.Log ("score"+MyScore);
		MyScoreDisplay.text = MyScore.ToString ();
		UnityEngine.SceneManagement.SceneManager.LoadScene (scenename); //loads next scene
		GameObject.Find("win").GetComponent<AudioSource> ().Play ();
	
		}
		if (MyScore == 3) { //display win screen when a score reaches 3
		UnityEngine.SceneManagement.SceneManager.LoadScene ("playeronewins"); //loads player one win screen

			}

	if (other.transform.root.gameObject.name == "player2") { //goes to next scene
			GameObject.Find("win").GetComponent<AudioSource> ().Play (); //play win sound
			MyScore2++; //increases score

			MyScoreDisplay2.text = MyScore2.ToString ();
			UnityEngine.SceneManagement.SceneManager.LoadScene (scenename); //loads next scene

		}

	if (MyScore2 == 3) { //display win screen when a score reaches 3
		UnityEngine.SceneManagement.SceneManager.LoadScene ("playertwowins"); //loads player one win screen

	}

}
}
