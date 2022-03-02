using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TextFadeScript : MonoBehaviour
{

    private bool TextHere = false;

    SceneManagerScript SceneHandler;

    GameObject SceneObject;

    public Animator transition;

    public float transtitiontime = 1f;

    void Awake()
    {
        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!TextHere)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<Text>()));
                TextHere = true;
            }
            else
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));
                Time.timeScale = 1f;
                StartCoroutine(LoadLevel("Bunker"));
            }

            
        }
    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }


    IEnumerator LoadLevel(string Scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transtitiontime);

        SceneHandler.LoadNewMap(Scene);
    }
}

