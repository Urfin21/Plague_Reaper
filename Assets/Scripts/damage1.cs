using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage1 : MonoBehaviour
{
    public int Bullet_collDamage = 1;
    public string Bullet_collTag;

    private void OnCollisionEnter2D(Collision2D coll1)
    {
        if (coll1.gameObject.tag == Bullet_collTag)
        {
            HPScript HP = coll1.gameObject.GetComponent<HPScript>();
            HP.TakeHit(Bullet_collDamage);
        }
    }
}
