﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public OptionsMenu optionsMenu;

	public void LevelSelect(int level)
	{
		optionsMenu.SetScene(level);
		SceneManager.LoadScene(level);
	}

	public void Options()
	{
		SceneManager.LoadScene(1);
	}

	public void ExitGame()
	{
		Debug.Log("Exited");
		Application.Quit();
	}
}
