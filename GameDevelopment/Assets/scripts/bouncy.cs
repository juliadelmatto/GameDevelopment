using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncy : MonoBehaviour {

	//amount of bounciness
	public float forceToAdd = 10f;
	public BoxCollider2D myCollider;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	//when ball hits wall
	void OnCollisionEnter2D(Collision2D gameObjectHittingMe)
	{


		//transform.position=startPos;
		gameObjectHittingMe.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 0, 0); //adds force when ball hits wall


		gameObjectHittingMe.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, forceToAdd), ForceMode2D.Impulse);
		//        }

	}
}
