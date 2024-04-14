using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float AttackSpeed;
    public float startAttackTime;

    public Transform attackpos_forward;
    public LayerMask Enemy;
    public LayerMask Enemy1;
    public LayerMask Enemy2;
    public float attackRange;
    public int attackCount;
    public Animator anim;
    public float exit = 0.4f;
    public float punch1 = 0.1f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("punch");
            Invoke("OnAttaack", punch1);
            Invoke("Exit", exit);
        }
    }

    public void OnAttaack()
    {

        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackpos_forward.position, attackRange, Enemy);
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<enemyAI>().TakeDamage(attackCount);
        }     
        Collider2D[] enemies1 = Physics2D.OverlapCircleAll(attackpos_forward.position, attackRange, Enemy1);
        for (int i = 0; i < enemies1.Length; i++)
        {
            enemies1[i].GetComponent<ToySoliderHP>().TakeDamage(attackCount);
        }
        Collider2D[] enemies2 = Physics2D.OverlapCircleAll(attackpos_forward.position, attackRange, Enemy2);
        for (int i = 0; i < enemies2.Length; i++)
        {
            enemies2[i].GetComponent<HP_BOSS>().TakeDamage(attackCount);
        }
    }
    public void Exit()
    {
        anim.SetTrigger("Exit");
    }
}
