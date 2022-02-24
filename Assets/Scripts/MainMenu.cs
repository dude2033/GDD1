using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    SceneManagerScript SceneHandler;

    GameObject SceneObject;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }
    public void StartGame(string Scene)
    {
        SceneHandler.LoadNewMap(Scene);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void Info(string Scene)
    {
        SceneHandler.LoadNewMap(Scene);
    }

    public void Back(string Scene)
    {
        SceneHandler.LoadNewMap(Scene);
    }

    public void Past(string Scene)
    {
        SceneHandler.LoadNewMap(Scene);
    }
}
