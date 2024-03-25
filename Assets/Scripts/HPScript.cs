using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPScript : MonoBehaviour
{
    [SerializeField] private int MaxHP;
    public int HP;
    public Image imgObj;
    public Sprite spriteImage;
    public Sprite spriteImage1;
    public Sprite spriteImage2;
    public float dead1 = 0f;
    public Animator anim;
    public GameObject main;
    public float GoodMod1 = 2f;
    public bool GoodMod = false;

    public void Update()
    {
        Change();
        if (HP == 0)
        {
            HP = 0;
            anim.SetTrigger("dead");
            Destroy();
        }
    }

    public void TakeHit(int damage)
    {
        if (GoodMod == true)
        {
            HP = HP;
        }
        else
        {
            HP -= damage;
            GoodMod = true;
            GoodMod2();
        }
    }

    public void GoodMod2()
    {
        Invoke("ExitGoodMod", GoodMod1);
    }

    public void ExitGoodMod()
    {
        GoodMod = false;
    }
    public void SetHP(int bonus)
    {
        HP += bonus;

        if (HP > MaxHP)
        {
            HP = MaxHP;
        }
    }
    public void Change()
    {
        if (HP == 2)
        {
            imgObj.sprite = spriteImage;
        }
        if (HP == 1)
        {
            imgObj.sprite = spriteImage1;
        }
        if (HP == 0)
        {
            imgObj.sprite = spriteImage2;
        }
    }
    public void Destroy()
    {
        main.GetComponent<ESC>().view1();
    }

}
