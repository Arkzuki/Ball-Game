using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGoalCounter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            red.goals += 1;
        }
        


    }

}
