using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP_BOSS : MonoBehaviour
{
    public int healthNow = 100;
    public float END1 = 2.4f;
    public Animator anim;

    void Update()
    {
        
        if (healthNow == 0)
        {
            anim.SetTrigger("DEATH");
            Invoke("END", END1);
        }
    }
    public void TakeDamage(int attackCount)
    {
        healthNow -= attackCount;
    }
    public void END()
    {
        Destroy(gameObject);
    }
}
