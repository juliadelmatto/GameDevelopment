using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishline : MonoBehaviour {

	//set score
	public static int MyScore;
	public Text MyScoreDisplay;
	public static int MyScore2;
	public Text MyScoreDisplay2;
	public string scenename;

	// Use this for initialization



	void Start () {
		//automatically sets the score so it will display every level
		MyScoreDisplay = GameObject.Find("player1score").GetComponent<Text>();
		MyScoreDisplay2 = GameObject.Find("player2score").GetComponent<Text>();
	
	}

	// Update is called once per frame
	void Update () {

	}
	//when the finishline collides with either player, their score will increase, and the level will change
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.root.gameObject.name == "player1"){
		MyScore++;//increases score
		Debug.Log ("score"+MyScore);
		MyScoreDisplay.text = MyScore.ToString ();
		UnityEngine.SceneManagement.SceneManager.LoadScene (scenename); //loads next scene

		}
		if (MyScore == 3) { //display win screen when a score reaches 2
		UnityEngine.SceneManagement.SceneManager.LoadScene ("playeronewins"); //loads player one win screen
			}

	if (other.transform.root.gameObject.name == "player2") { //goes to next scene
			MyScore2++; //increases score
			MyScoreDisplay2.text = MyScore2.ToString ();
			UnityEngine.SceneManagement.SceneManager.LoadScene (scenename); //loads next scene
		}

	if (MyScore2 == 3) { //display win screen when a score reaches 2
		UnityEngine.SceneManagement.SceneManager.LoadScene ("playertwowins"); //loads player one win screen
	}

}
}
