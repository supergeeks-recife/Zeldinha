using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeldinhaPlayer : MonoBehaviour
{

    public Rigidbody2D body;
    public float speed;
    float moveX;
    float moveY;
    bool isMoving;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        Move();
        Animation();
    }

    void Move()
    {
        body.MovePosition(transform.position + new Vector3(moveX, moveY, 0) * speed * Time.deltaTime);
    }

    void Animation()
    {
        if(moveX == 0 && moveY == 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }

        anim.SetBool("isMoving", isMoving);
    }
}
