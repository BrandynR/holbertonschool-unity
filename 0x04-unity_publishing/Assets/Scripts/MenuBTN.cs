using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBTN : MonoBehaviour
{

    // Update is called once per frame
    public void loadMenu()
    {
       SceneManager.LoadScene("menu"); 
    }
}
