using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squarecontroller : MonoBehaviour {

	public GameObject particlePrefab;
	public ParticleSystem activeParticles;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (activeParticles != null) { //are there any active particles right now?
			if (activeParticles.isStopped) { //have they stopped animating
				Destroy (activeParticles.gameObject); //if so, destroy them
			}
		}
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		//instantiate particle system and assign it to temporary variable p
		GameObject particleObj = Instantiate (particlePrefab.gameObject);

		//set the parent of particle system to the square
		particleObj.transform.parent = collision.gameObject.transform;
		//set the position of the particle system to the origin of the square
		particleObj.transform.localPosition = Vector3.zero;

		ParticleSystem p = particleObj.GetComponent<ParticleSystem> ();
		activeParticles = particleObj.GetComponent<ParticleSystem> ();
	}
}
