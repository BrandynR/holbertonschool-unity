﻿/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {

	int backScene;
    public Toggle inverted;
	public void Back()
	{
		SceneManager.LoadScene(backScene);
	}

	public void SetScene(int prevScene)
	{
		backScene = prevScene;
	}
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle inverted;
    int backScene;

    /*private void Start()
    {
        if (PlayerPrefs.GetString("IsInverted") != "")
            if (bool.Parse(PlayerPrefs.GetString("IsInverted")) != inverted.isOn)
                inverted.isOn = bool.Parse(PlayerPrefs.GetString("IsInverted"));
    }*/
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("PreviousScene"));
    }

    public void Apply()
    {
        PlayerPrefs.SetString("IsInverted", inverted.isOn.ToString());
    }
    public void SetScene(int prevScene)
	{
		backScene = prevScene;
	}
}