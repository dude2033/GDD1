using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstRiddleCallScript : MonoBehaviour
{

    public static bool isGamePaused = false;
    [SerializeField] GameObject Riddle;

    [SerializeField] GameObject TeleportButton;
 /*   void OnMouseDown()
    {
        isGamePaused = true;
        StartRiddle();
    }
*/

    public void CustomOnMouseDown()
    {
        isGamePaused = true;
        StartRiddle();
    }

    void StartRiddle()
    {
        if (isGamePaused)
        {
            Riddle.SetActive(true);
            TeleportButton.SetActive(false);
            Time.timeScale = 0f;
            isGamePaused = true;
        }
    }
    public void Back()
    {
        Riddle.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
}
