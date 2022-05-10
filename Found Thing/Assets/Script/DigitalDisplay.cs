using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalDisplay : MonoBehaviour
{
    public Text codeText;
    public Text timerText;
    public string codeTextValue = "";
    public GameObject HackerApp;
    public float Timer = 60f;
    public GameObject HackerScreen;
    public GameObject HackerEndingImage;
    public GameObject HackerEndingtext;

    private void Update()
    {
        codeText.text = codeTextValue;
        if (codeTextValue == "2569")
        {
            ChangeNum.isSafeOpened = true;
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }

        if (HackerApp.activeInHierarchy == true)
        {
            Timer -= Time.deltaTime;
            timerText.text = Timer.ToString("f00");
        }

        if (Timer <= 0)
        {
            HackerScreen.SetActive(true);
            HackerApp.SetActive(false);
            Timer = 60;
            HackerEndingImage.SetActive(true);
            HackerEndingtext.SetActive(true);
        }
    }
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
