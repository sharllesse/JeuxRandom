using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class launchLoL : MonoBehaviour
{
    public GameObject LaunchLoL;
    public BlueScreenEnding _blueScreenEnding;
    public float Timer = 3;
    public float Timers = 1;
    public float TimersS = 1;
    public GameObject GameObject1;
    public GameObject GameObject2;
    public bool forTheTimer;
    public bool forTheTimers;
    public bool forTheTimersS;

    [Header("Blue screen")]
    public GameObject BlueScreen;
    public AudioClip blueScreenSound;
    public AudioSource AudioSource;
    public GameObject BlueScreenEndings;
    public GameObject BlueScreenEndingsText;

    public void Update()
    {
        if (_blueScreenEnding.isBlueScreen == true) 
        {
            LaunchLoL.SetActive(true);
            Timer -= Time.deltaTime;
        }

        if (Timer <= 0)
        {
            _blueScreenEnding.isBlueScreen = false;
            LaunchLoL.SetActive(false);
            Timer = 3;
            forTheTimers = true;
        }
        
        
        if (forTheTimers == true)
        {
            GameObject1.SetActive(true);
            forTheTimer = true;
        }

        if (forTheTimer == true)
        {
            Timers -= Time.deltaTime;
        }

        if (Timers <= 0)
        {
            Timers = 1;
            forTheTimer = false;
            GameObject2.SetActive(true);
            forTheTimers = false;
            forTheTimersS = true;
        }

        if (forTheTimersS == true)
        {
            TimersS -= Time.deltaTime;
        }

        if (TimersS <= 0)
        {
            forTheTimersS = false;
            TimersS = 1;
            AudioSource.PlayOneShot(blueScreenSound);
            BlueScreen.SetActive(true);
            GameObject2.SetActive(false);
            GameObject1.SetActive(false);
            BlueScreenEndings.SetActive(true);
            BlueScreenEndingsText.SetActive(true);
        }
    }
}
