using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScreenEnding : MonoBehaviour
{
    public GameObject BlueScreenEndings;
    public GameObject BlueScreenEndingsText;
    public GameObject BlueScreen;

    private void Update()
    {
        if (BlueScreen.activeInHierarchy == true)
        {
            BlueScreenEndings.SetActive(true);
            BlueScreenEndingsText.SetActive(true);
        }
    }
}
