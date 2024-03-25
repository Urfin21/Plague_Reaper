using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySoliderHP : MonoBehaviour
{
    public int health;
    public Animator anim;
    public float Back1 = 0.3f;

    void Start()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int attackCount)
    {
        health -= attackCount;
    }
    public void FlipMain()
    {
        transform.Rotate(new Vector3(0, 180, 0));
    }
    public void Anima()
    {
        anim.SetTrigger("shot");
        Invoke("Back", Back1);
    }
    public void Back()
    {
        anim.SetTrigger("Back");
    }
}
