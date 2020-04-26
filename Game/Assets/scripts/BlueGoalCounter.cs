using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGoalCounter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            blue.goals += 1;
        }



    }
}
