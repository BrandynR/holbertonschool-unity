using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour {

	int backScene;

	public void Back()
	{
		SceneManager.LoadScene(backScene);
	}

	public void SetScene(int prevScene)
	{
		backScene = prevScene;
	}
}
