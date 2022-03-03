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

    public GameObject Bodyguard;
    public bool conditionToMove = false;

    private bool startMoving;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myTransform = GetComponent<Transform>();
        myRg = GetComponent<Rigidbody2D>();
        startMoving = false;

    }

    // Update is called once per frame
    void Update()
    {
        Changedir();
        Move();
    }

    private void Move()
    {
        myRg.MovePosition(myTransform.position + dir * speed * Time.deltaTime);
    }

    private void Changedir()
    {
        if (startMoving)
        {
            dir = Vector3.right;
        }
        UpdateAnimation();

    }

    void UpdateAnimation()
    {

        if (conditionToMove)
        {
            anim.SetBool("StartMove", false);
            startMoving = true;
            anim.SetFloat("MoveX", dir.x);
            anim.SetFloat("MoveY", dir.y);
        }
        else
        {
            startMoving = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        if (other.gameObject.name != "MainPlayer")
        {
            inventory.BodyGuard = true;
            Bodyguard.SetActive(false);
        }
    }
}
