using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public float speed = 2f;
    public float CircleRadius = 0.5f;
    private Rigidbody2D EnemyRB;
    public GameObject groundCheakEnemy1;
    public LayerMask Wall;
    public LayerMask Ground;
    public bool FacingRight;
    public bool isWall;
    public bool isGround;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyRB.velocity = Vector2.right*speed*Time.deltaTime;
        isWall = Physics2D.OverlapCircle(groundCheakEnemy1.transform.position, CircleRadius, Wall);
        isGround = Physics2D.OverlapCircle(groundCheakEnemy1.transform.position, CircleRadius, Ground);
        if (isWall && FacingRight)
        {
            flip();
        }
        else if(isWall && !FacingRight)
        {
            flip();
        }
        if(!isGround && FacingRight)
        {
            flip();
        }
        else if (!isGround && !FacingRight)
        {
            flip();
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void flip()
    {
        FacingRight = !FacingRight;
        transform.Rotate(new Vector3(0, 180, 0));
        speed = -speed;
    }

    public void TakeDamage(int attackCount)
    {
        health -= attackCount;
    }
}
