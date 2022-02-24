using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLadyBehavior : MonoBehaviour
{
    public GameObject MainPlayer;
    Vector2 targetVec;
    float diffAngle;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {


        targetVec = MainPlayer.transform.position - transform.position;


        diffAngle = Vector2.SignedAngle(transform.up, targetVec);



        changelook();

    }

    void changelook()
    {
        Debug.Log(diffAngle);
        if (diffAngle < 130 && diffAngle > 75)
        {
            anim.SetBool("Left", true);
        }
        else if (diffAngle > 150 && diffAngle < 180 || diffAngle > -179 && diffAngle < -130)
        {
            anim.SetBool("Down", true);
        }
        else if (diffAngle < -70 && diffAngle > -130)
        {
            anim.SetBool("Right", true);
        }
        else if (diffAngle > -70 && diffAngle < 100)
        {
            anim.SetBool("Left", false);
            anim.SetBool("Down", false);
            anim.SetBool("Right", false);
        }
        else
        {
            anim.SetBool("Left", false);
            anim.SetBool("Down", false);
            anim.SetBool("Right", false);
        }
    }
}
