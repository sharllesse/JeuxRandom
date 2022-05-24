using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScreenEnding : MonoBehaviour
{
    public GameObject BlueScreenEndings;
    public GameObject BlueScreenEndingsText;
    public GameObject BlueScreen;
    public AudioClip blueScreenSound;
    public AudioSource AudioSource;
    
    public float timer = 1f;
    //public bool timers;

    public void Bluescreen()
    {
        BlueScreenEndings.SetActive(true);
        BlueScreenEndingsText.SetActive(true);
        AudioSource.PlayOneShot(blueScreenSound);
    }
    /*private void Update()
    {
        if (BlueScreen.activeInHierarchy == true)
        {
            BlueScreenEndings.SetActive(true);
            BlueScreenEndingsText.SetActive(true);
            timer -= Time.deltaTime;
        }

        if (timer == 0) 
        {
            AudioSource.PlayOneShot(blueScreenSound);
        }
    }*/
}
