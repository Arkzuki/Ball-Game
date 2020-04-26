using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tibbers : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 7f;
    public GameObject tibe;
    public Transform spa;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public float lifetime;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ball"))
        {
            TDeath();
        }
    }

    void Update()
    {

        if (timeBtwShots <= 0)
        {



            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(tibe, spa.position, transform.rotation);

                timeBtwShots = startTimeBtwShots;

            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
    public void TDeath()
    {
        if (lifetime <= 0)
        {


            Destroy(gameObject);
        }
        else
        {
            lifetime -= Time.deltaTime;
        }
    }
}
