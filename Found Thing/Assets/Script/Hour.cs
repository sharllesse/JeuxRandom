using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour : MonoBehaviour
{
    public float Second = 0f;
    public float Minute = 00f;
    public float Heure = 00f;
    public UnityEngine.UI.Text TextLogAmount;

    private void Start()
    {
        TextLogAmount = GameObject.Find ("Heure").GetComponent<UnityEngine.UI.Text>();
    }

    private void Update()
    {
        TextLogAmount.text = Heure.ToString();
        Second += Time.deltaTime;

        if (Second >= 60f)
        {
            Second = 0;
            Minute++;
        }

        if (Minute >= 60f)
        {
            Minute = 0;
            Heure++;
        }
    }
}
