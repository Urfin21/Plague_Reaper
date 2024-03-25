using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public float jumpForce = 7;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheakingGround();
        walk();
        jump();
        flip();
        anim.SetFloat("yVelocity", rb.velocity.y);
    }

    void walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }

    void CheakingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkPadius, Ground);
        anim.SetBool("jump", !onGround);
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector2.up * jumpForce);
            anim.SetBool("jump", true);
        }
    }

    public bool onGround;
    public Transform GroundCheck;
    public float checkPadius = 0.5f;
    public LayerMask Ground;

    public bool faceRight = true;

    void flip()
    {
        if (moveVector.x > 0 && !faceRight || moveVector.x < 0 && faceRight)
        {
            Vector3 currentScale = gameObject.transform.localScale;
            currentScale.x *= -1;
            gameObject.transform.localScale = currentScale;
            faceRight = !faceRight;
        }
    }
}

