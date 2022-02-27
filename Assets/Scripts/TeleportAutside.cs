using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAutside : MonoBehaviour
{

    SceneManagerScript SceneHandler;

    public string Scene_new;
    GameObject SceneObject;
    public Animator transition;

    public float transtitiontime = 1f;

    void Awake()
    {
        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(LoadLevel(Scene_new));
    }

    IEnumerator LoadLevel(string Scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transtitiontime);

        SceneHandler.LoadNewMap(Scene);
    }
}
