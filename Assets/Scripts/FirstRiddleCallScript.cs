using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstRiddleCallScript : MonoBehaviour
{
    public string Scene;

    void OnMouseDown()
    {
        SceneManager.LoadScene(Scene);
    }
}
