using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class CloseWindowsTab : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool IsClick;
    public bool IsOnIt;
    public GameObject winButton;
    public GameObject TabButton;
    public GameObject UndoOpen;

    private void Update()
    {
        if (IsOnIt == true && IsClick == true)
        {
            winButton.SetActive(false);
            TabButton.SetActive(false);
            UndoOpen.SetActive(false);
        }

        if (winButton.activeInHierarchy == false)
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
