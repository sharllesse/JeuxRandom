using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldAdresse : MonoBehaviour
{
    public InputField inputField;
    public string myText;
    public GameObject Video;
    public GameObject Video2;
    public GameObject RickEnding;
    public GameObject RickEndingText;

    private void Update()
    {
        myText = inputField.text;
        if (myText == "https://www.youtube.com/watch?v=iik25wqIuFo")
        {
            Video.SetActive(true);
            Video2.SetActive(true);
            RickEnding.SetActive(true);
            RickEndingText.SetActive(true);
        }

        if (myText == "")
        {
            Video.SetActive(false);
            Video2.SetActive(false);
        }
        
    }
}
