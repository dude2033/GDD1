using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public static bool isOption = true;
    SceneManagerScript SceneHandler;
    [SerializeField] GameObject SceneObject;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject optionMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isGamePaused)
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    void Awake()
    {
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }

    public void MainMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        SceneHandler.LoadNewMap("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Dei Mama quits");
    }

    public void Option()
    {
        if (isOption)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 0f;
            optionMenu.SetActive(true);
            isOption = false;
        }
        else
        {
            Back();
        }
    }

    public void Back()
    {
        optionMenu.SetActive(false);
        isOption = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

}
