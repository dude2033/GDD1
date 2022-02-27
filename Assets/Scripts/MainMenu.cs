using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    SceneManagerScript SceneHandler;

    GameObject SceneObject;

    public Animator transition;

    public float transtitiontime = 1f;
    void Start()
    {
       // Riddle.SetActive(false);
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
        StartCoroutine(LoadLevel(Scene));
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void Info(string Scene)
    {
        StartCoroutine(LoadLevel(Scene));
    }

    public void Back(string Scene)
    {
        StartCoroutine(LoadLevel(Scene));
    }

    public void Past(string Scene)
    {
        Time.timeScale = 1f;
        StartCoroutine(LoadLevel(Scene));
    }

    IEnumerator LoadLevel(string Scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transtitiontime);

        SceneHandler.LoadNewMap(Scene);
    }

}
