using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject SelectedSkin;
    public GameObject Player;
    private Sprite PlayerSprite;

    public RuntimeAnimatorController male;
    public RuntimeAnimatorController female;

    void Start()
    {
        PlayerSprite = SelectedSkin.GetComponent<SpriteRenderer>().sprite;
        Player.GetComponent<SpriteRenderer>().sprite = PlayerSprite;

        if (PlayerSprite.name == "Women_neu_0")
        {
            Player.gameObject.GetComponent<Animator>().runtimeAnimatorController = Instantiate(female) as RuntimeAnimatorController;
        }
        if (PlayerSprite.name == "Men_neu_0")
        {
            Player.gameObject.GetComponent<Animator>().runtimeAnimatorController = Instantiate(male) as RuntimeAnimatorController;
        }
    }
}
