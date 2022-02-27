﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerskin;

    SceneManagerScript SceneHandler;

    GameObject SceneObject;

    public Animator transition;

    public float transtitiontime = 1f;

    void Awake()
    {
        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }

    public void NextOption()
    {
        selectedSkin = selectedSkin + 1;
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        spriteRenderer.sprite = skins[selectedSkin];
    }
    public void BackOption()
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }
        spriteRenderer.sprite = skins[selectedSkin];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Prefabs/SelectSkin.prefab");
        StartCoroutine(LoadLevel("Bunker"));
    }

    IEnumerator LoadLevel(string Scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transtitiontime);

        SceneHandler.LoadNewMap(Scene);
    }
}
