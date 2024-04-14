using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLIP1 : MonoBehaviour
{
    public GameObject main;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            main.GetComponent<ATTACK_BOSS>().FlipMain();
        }
    }
}
