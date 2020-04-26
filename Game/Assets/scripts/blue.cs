using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blue : MonoBehaviour
{
    Text text;
    public static int goals;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = goals.ToString();
    }
}
