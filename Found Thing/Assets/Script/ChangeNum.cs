using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNum : MonoBehaviour
{
    public static bool isSafeOpened = false;
    public GameObject HackerApp;
    public DigitalDisplay DigitalDisplay;
    public float Timer = 1;
    public GameObject HackerEndingImage;
    public GameObject HackerEndingtext;

    private void Update()
    {
        if (isSafeOpened)
        {
            HackerApp.SetActive(false);
            DigitalDisplay.Timer = 60f;
            Timer -= Time.deltaTime;
            HackerEndingImage.SetActive(true);
            HackerEndingtext.SetActive(true);
        }

        if (Timer <= 0)
        {
            Timer = 1;
            isSafeOpened = false;
        }
    }
}
