using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class newscene : MonoBehaviour {

	public void LoadScene(string sceneName) //loads scene
	{
		SceneManager.LoadScene (sceneName);
	}

}
