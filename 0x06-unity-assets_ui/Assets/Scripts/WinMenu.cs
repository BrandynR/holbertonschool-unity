using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void Next()
    {
        
        int y = SceneManager.GetActiveScene().buildIndex;

        if (y == 4)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(y + 1);
        }
    }
}
