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
    public bool isBlueScreen;

    /*public void Bluescreens()
    {
        BlueScreenEndings.SetActive(true);
        BlueScreenEndingsText.SetActive(true);
        AudioSource.PlayOneShot(blueScreenSound);
        BlueScreen.SetActive(true);
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

    public void Bluescreens()
    {
        isBlueScreen = true;
    }
}
