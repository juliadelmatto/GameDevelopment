using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class newscene : MonoBehaviour {

	public void LoadScene(string sceneName) //set scene name
	{
		SceneManager.LoadScene (sceneName); //loads scene
	}

}
