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

    GameObject SoundManagerObject;
    SoundManagerScript SoundManager;

    public float transtitiontime = 1f;


    void Awake()
    {
        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
        SoundManagerObject = GameObject.FindGameObjectWithTag("SoundManager");
        SoundManager = SoundManagerObject.GetComponent<SoundManagerScript>();
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

        SoundManager.ChangeSound("Bunker");

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
                 GameObject.FindGameObjectWithTag("Inventory").gameObject.SetActive(false);
                Debug.Log("fromPast");
                SoundManager.ChangeSound("FutureBad");
                SceneHandler.LoadNewMap("FutureBad");
            }
            else
            {
                SoundManager.ChangeSound("FutureBad");
                SceneHandler.LoadNewMap("FutureBad");
            }
        }
        else if (isGoodFuture)
        {
            GameObject.FindGameObjectWithTag("Inventory").gameObject.SetActive(false);
            SoundManager.ChangeSound("FutureGood");
            SceneHandler.LoadNewMap("FutureGood");
        }
    }
}
