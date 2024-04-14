using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public GameObject BOSS;
    public int StayAll = 0;
    public bool Damage = false;
    public GameObject Player;
    public int Boss_Panch_Damage = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            BOSS.GetComponent<ATTACK_BOSS>().PUNCH();
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Damage != true)
        {
            if (StayAll == 120)
            {
                BOSS.GetComponent<ATTACK_BOSS>().STAYZONE();
            }
            else
            {
                StayAll = StayAll + 1;
            }
        }
        if (other.CompareTag("Player") && Damage == true)
        {
            HPScript HP = Player.gameObject.GetComponent<HPScript>();
            HP.TakeHit(Boss_Panch_Damage);
            Damage = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StayAll = 0;
        }
    }
    public void Damage1()
    {
        Damage = true;
    }
}
