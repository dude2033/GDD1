using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
private string nameOfSceneToLoad;
    private string nameOfCurrentScene;
    public string nameOfInitialMapScene;

    // Start is called before the first frame update
    void Start()
    {
        LoadMap(nameOfInitialMapScene);
    }

    private void LoadMap(string newMap)
    {
        nameOfCurrentScene = newMap;
        SceneManager.LoadScene(newMap, LoadSceneMode.Additive);
    }

    public void LoadNewMap(string newMap)
    {
        SceneManager.sceneUnloaded += UnloadMap;
        this.nameOfSceneToLoad = newMap;
        SceneManager.UnloadSceneAsync(nameOfCurrentScene);
    }

    private void UnloadMap(Scene undloadScene)
    {
        SceneManager.sceneUnloaded -= UnloadMap;
        if(!SceneManager.GetSceneByName(nameOfSceneToLoad).isLoaded)
            LoadMap(nameOfSceneToLoad);
    }
}
