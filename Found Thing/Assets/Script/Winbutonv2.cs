using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;


public class Winbutonv2 : MonoBehaviour , IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool IsClick;
    public GameObject select1;
    public GameObject select2;
    public GameObject select3;
    public GameObject select4;
    public GameObject select5;
    public GameObject select6;
    public bool IsOnIt;
    public Image Image1;
    public Image Image2;
    public Image Image3;
    public Image Image4;
    public Image Image5;
    public Image Image6;

    private void Update()
    {
        if (IsOnIt == true && IsClick == true)
        {
            select1.SetActive(false);
            select2.SetActive(false);
            select3.SetActive(false);
            select4.SetActive(false);
            select5.SetActive(false);
            select6.SetActive(false);
            Image1.color = new Color32(255, 255, 255, 255);
            Image2.color = new Color32(255, 255, 255, 255);
            Image3.color = new Color32(255, 255, 255, 255);
            Image4.color = new Color32(255, 255, 255, 255);
            Image5.color = new Color32(255, 255, 255, 255);
            Image6.color = new Color32(255, 255, 255, 255);
        }

        if (select1.activeInHierarchy == true || select2.activeInHierarchy == true || select3.activeInHierarchy == true || select4.activeInHierarchy == true || select5.activeInHierarchy == true || select6.activeInHierarchy == true)
        {
            IsClick = false;
        }
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        IsClick = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        IsOnIt = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        IsOnIt = false;
    }
}
