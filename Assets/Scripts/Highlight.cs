using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    private Renderer render;
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        render.material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        render.material.color = Color.white;
    }
}
