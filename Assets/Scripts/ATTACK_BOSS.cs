using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATTACK_BOSS : MonoBehaviour
{
    public float TimeFull = 1f;
    public float TimeNow = 0f;
    public Animator anim;
    public float PUNCH_EXIT = 1.1f;
    public float RUN_EXIT = 1.4f;
    private Rigidbody2D BossRB;
    public float speed = 10f;
    public float JUMP_EXIT = 3.2f;
    public float Time = 0f;
    public float JUMPSFULL = 1f;
    public float JUMPSNOW = 0f;
    public float papa = 1f;
    public int kd = 0;
    public GameObject jump_run;
    public GameObject punch;
    public float jumpAmount = 5f;
    public float speed1 = 7.5f;

    public void Update()
    {
        Time = Time + 1f;
    }
    public void Start()
    {
        BossRB = GetComponent<Rigidbody2D>();
    }
    public void JUMP()
    {
        if (Time >= 3000)
        {
            if (JUMPSNOW >= JUMPSFULL)
            {;
                Time = 0;
                JUMPSNOW = 0;
                anim.SetTrigger("JUMP");
                BossRB.velocity = Vector2.right * speed1 * 3f;
                BossRB.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
                Invoke("EXIT_ANIMATION", JUMP_EXIT);
                papa = 1f;
                jump_run.gameObject.GetComponent<run_jamp>().Damage1();
            }
            else
            {
                Time = 0;
                JUMPSNOW = 0;
            }

        }
        else
        {
            JUMPSNOW = JUMPSNOW + 1;
        }
    }
    public void PUNCH()
    {
        if (TimeNow >= TimeFull)
        {
            TimeNow = 0;
            anim.SetTrigger("PUNCH");
            punch.gameObject.GetComponent<Punch>().Damage1();
            Invoke("EXIT_ANIMATION", PUNCH_EXIT);
            papa = 1f;
        }
        else
        {
            TimeNow = TimeNow + 1;
        }
    }
    public void RUN()
    {
        anim.SetTrigger("RUN");
        BossRB.velocity = Vector2.right * speed * 1.3f;
        Invoke("EXIT_ANIMATION", RUN_EXIT);
        jump_run.gameObject.GetComponent<run_jamp>().Damage1();
    }
    public void EXIT_ANIMATION()
    {
        anim.SetTrigger("EXIT_ANIM");
    }
    public void STAYZONE()
    {
        TimeNow = 4f;
        PUNCH();
    }
    public void STAYZONE1()
    {
        RUN();
    }
    public void FlipMain()
    {
        transform.Rotate(new Vector3(0, 180, 0));
        speed = -speed;
        speed1 = -speed1;
    }
}
