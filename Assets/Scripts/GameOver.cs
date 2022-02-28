using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    SceneManagerScript SceneHandler;
    GameObject SceneObject;
    public GameObject Player;
    public Animator transition;

    public GameObject MainCamera;

    public GameObject Camera;

    public float transtitiontime = 1f;

    void Awake()
    {

        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }

    void Start()
    {
        if (TeleportAutside.fromPast == true)
        {
            Camera.SetActive(true);
            MainCamera.SetActive(false);
            Player.GetComponent<PlayerMovement>().moveSpeed = 0;
            StartCoroutine(LoadGameOver());
        }
    }

    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(6);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(6);
        SceneHandler.LoadNewMap("EndScene");
    }
}
