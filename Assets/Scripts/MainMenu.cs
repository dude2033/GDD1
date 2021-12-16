using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void Info(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void Back(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
