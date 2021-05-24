using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnPress : MonoBehaviour
{
    public string SceneToLoad = "MainMenu";
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
