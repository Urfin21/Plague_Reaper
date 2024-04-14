using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public GameObject BOSS;
    public int StayAll = 0;

    private void OnTriggerStay2D(Collider2D other1)
    {
        if (other1.CompareTag("Player"))
        {
            if (StayAll == 300)
            {
                BOSS.GetComponent<ATTACK_BOSS>().STAYZONE1();
            }
            else
            {
                StayAll = StayAll + 1;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other1)
    {
        if (other1.CompareTag("Player"))
        {
            StayAll = 0;
        }
    }
}
