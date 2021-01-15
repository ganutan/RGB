using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public GameObject cube;
    

    public void ChangeMenuScene(string scenename)
    {
        DontDestroyOnLoad(cube.GetComponent<Renderer>().material); 
        SceneManager.LoadScene(scenename);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

