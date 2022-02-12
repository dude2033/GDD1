using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject SelectedSkin;
    public GameObject Player;
    private Sprite PlayerSprite;
    void Start()
    {
        PlayerSprite = SelectedSkin.GetComponent<SpriteRenderer>().sprite;
        Player.GetComponent<SpriteRenderer>().sprite = PlayerSprite;
    }
}
