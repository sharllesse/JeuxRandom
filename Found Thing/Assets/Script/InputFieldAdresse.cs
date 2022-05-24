using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldAdresse : MonoBehaviour
{
    public GameObject Video1;
    public GameObject Video2;
    public GameObject Video3;
    public GameObject Video4;
    public GameObject Video21;
    public GameObject Video22;
    public GameObject Video23;
    public GameObject Video24;
    public GameObject Video24rick;
    public GameObject Video24rickending;
    public GameObject Video24rickendingtext;

    public void ClickOnTheVideo()
    {
        Video1.SetActive(true);
        Video21.SetActive(true);
        Video2.SetActive(false);
        Video22.SetActive(false);
        Video3.SetActive(false);
        Video23.SetActive(false);
        Video4.SetActive(false);
        Video24.SetActive(false);
    }

    public void Update()
    {
        if (Video24rick.activeInHierarchy == true)
        {
            Video24rickending.SetActive(true);
            Video24rickendingtext.SetActive(true);
        }
    }
}
