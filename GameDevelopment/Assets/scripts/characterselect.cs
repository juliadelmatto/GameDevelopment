using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

	public class characterselect : MonoBehaviour {
	public Sprite img1;

		
	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
		//gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load("redcircle", typeof(Sprite)) as Sprite;

	
	void Start () {
		img1 = Resources.Load("redcircle", typeof(Sprite)) as Sprite;

	}
	

	void Update () {
		//if button is pressed
		GameObject.Find ("player1").gameObject.GetComponent<SpriteRenderer>().sprite = img1;

	}
}
