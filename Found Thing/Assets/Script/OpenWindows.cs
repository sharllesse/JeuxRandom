using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Image = UnityEngine.UI.Image;

public class OpenWindows : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public GameObject winButton;
    public GameObject TabButton;
    public GameObject UndoOpen;

    public bool IsSelect;
    public bool IsClick;
    public bool IsOnIt;

    void Update()
    {
        if (IsClick == true && IsOnIt == true)
        {
            winButton.SetActive(true);
            TabButton.SetActive(true);
            UndoOpen.SetActive(true);
        }

        if (winButton.activeInHierarchy == false && TabButton.activeInHierarchy == false && UndoOpen.activeInHierarchy == false)
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

    public void OnPointerDown(PointerEventData eventData)
    {
        IsSelect = true;
    }
}
