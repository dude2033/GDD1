using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    private Vector3 dir;
    private Transform myTransform;
    public float speed;
    private Rigidbody2D myRg;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myTransform = GetComponent<Transform>();
        myRg = GetComponent<Rigidbody2D>();
        Changedir();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        myRg.MovePosition(myTransform.position + dir * speed * Time.deltaTime);
    }

    private void Changedir()
    {
        dir = Vector3.right;
        UpdateAnimation();
    }

    void UpdateAnimation()
    {
        anim.SetFloat("MoveX", dir.x);
        anim.SetFloat("MoveY", dir.y);
    }
}
