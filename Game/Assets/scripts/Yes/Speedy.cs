using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedy : MonoBehaviour
{
    public float cooldownTime = 5f;
    private float nextFireTime = 0f;
    public float extraspeed;
    public mo mo;
    public float time = 2f;

    private void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                nextFireTime = Time.time + cooldownTime;
                mo.speed = mo.speed + extraspeed;
                StartCoroutine (stopspeed());

            }
        }
    }
    IEnumerator stopspeed()
    {
        yield return new WaitForSeconds(time);
        mo.speed = 3;

    }
}
