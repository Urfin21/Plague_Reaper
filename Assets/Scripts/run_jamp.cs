using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run_jamp : MonoBehaviour
{
    public bool Damage = false;
    public int Boss_Panch_Damage = 1;
    public GameObject Player;


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Damage == true)
        {
            HPScript HP = Player.gameObject.GetComponent<HPScript>();
            HP.TakeHit(Boss_Panch_Damage);
            Damage = false;
        }
    }
    public void Damage1()
    {
        Damage = true;
    }
}
