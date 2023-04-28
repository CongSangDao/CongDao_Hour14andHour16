using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutGame : MonoBehaviour
{
    public string sceneToLoad = "AboutGame";


    public void LoadGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
