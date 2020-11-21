using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    public GameObject gameCanvas;
    public GameObject quitCanvas;
    public GameObject replayCanvas;

    public void Restart()
    {
        SceneManager.LoadScene("ARSlingshotGame");
    }
    public void quitGame()
	{
        if (replayCanvas.activeSelf)
			{
                replayCanvas.SetActive(false);
            }
		gameCanvas.SetActive(false);
		quitCanvas.SetActive(true);
	}

	/// <summary>
	/// Quits the game if the player confirms they want to quit
	/// </summary>
	public void quitYes()
	{
		Application.Quit();
	}

	/// <summary>
	/// Goes back to the game if the user decides they don't want to quit
	/// </summary>
	public void quitNo()
	{
		gameCanvas.SetActive(true);
		quitCanvas.SetActive(false);
	}
}
