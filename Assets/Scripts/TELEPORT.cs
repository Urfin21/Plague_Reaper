using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TELEPORT : MonoBehaviour
{
    public GameObject pointTeleport;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.gameObject.transform.position = pointTeleport.gameObject.transform.position;

        }
    }
}