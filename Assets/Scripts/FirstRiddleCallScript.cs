using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstRiddleCallScript : MonoBehaviour
{
    public string Scene;
    SceneManagerScript SceneHandler;

    GameObject SceneObject;

    void Awake()
    {
        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }
    void OnMouseDown()
    {
        SceneHandler.LoadNewMap(Scene);
    }
}
