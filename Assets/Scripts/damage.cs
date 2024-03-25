using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int BOX_collDamage = 1;
    public string BOX_collTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == BOX_collTag)
        {
            HPScript HP = coll.gameObject.GetComponent<HPScript>();
            HP.TakeHit(BOX_collDamage);
        }
    }
}
