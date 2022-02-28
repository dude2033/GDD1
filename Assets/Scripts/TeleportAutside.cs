using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAutside : MonoBehaviour
{

    SceneManagerScript SceneHandler;
    public static bool isGoodFuture = false;
    public static bool isBadFuture = true;
    public static bool bunker = true;
    public static bool fromPast = false;
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
        if (bunker)
        {
            bunker = false;
            StartCoroutine(LoadLevel());
        }
        else
        {
            bunker = true;
            StartCoroutine(LoadBunker());
        }
    }

    IEnumerator LoadBunker()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transtitiontime);

        SceneHandler.LoadNewMap("Bunker");
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transtitiontime);

        if (isBadFuture)
        {
            if (fromPast)
            {
                Debug.Log("fromPast");
                SceneHandler.LoadNewMap("FutureBad");
            }
            else
            {
                SceneHandler.LoadNewMap("FutureBad");
            }
        }
        else if (isGoodFuture)
        {
            SceneHandler.LoadNewMap("FutureGood");
        }
    }
}
