using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour {

	int backScene;

	public void Back()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void SetScene(int prevScene)
	{
		backScene = prevScene;
	}
}
