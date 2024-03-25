using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySolider : MonoBehaviour
{

    [SerializeField] 
    GameObject bullet;

    float fireRate;

    float nextFire;
    public float Back1 = 0.1f;
    public GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;
    }
    void Update()
    {
    }

    // Update is called once per frame
    void CheakifTimetoFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
            main.GetComponent<ToySoliderHP>().Anima();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CheakifTimetoFire();
        }
    }

}
