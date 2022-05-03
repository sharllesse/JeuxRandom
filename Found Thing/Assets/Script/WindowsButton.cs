using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Image = UnityEngine.UI.Image;

public class WindowsButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public float Timer = 1;
    public bool DoubleClick;
    public bool TimerStart;
    public float Click = 0;

    public GameObject Folder;

    public bool IsSelect;
    public bool IsClick;
    public GameObject select;
    public Image _Image;
    public bool IsOnIt;
    public Image Image2;
    public GameObject select2;
    public Image Image3;
    public GameObject select3;
    public Image Image4;
    public GameObject select4;
    public Image Image5;
    public GameObject select5;
    public Image Image6;
    public GameObject select6;
    
    void Update()
    {
        if (IsClick == true && IsOnIt == true)
        {
            select.SetActive(true);
            _Image.color = new Color32(54, 68, 183, 255);
            select2.SetActive(false);
            Image2.color = new Color32(255, 255, 255, 255);
            select3.SetActive(false);
            Image3.color = new Color32(255, 255, 255, 255);
            select4.SetActive(false);
            Image4.color = new Color32(255, 255, 255, 255);
            select5.SetActive(false);
            Image5.color = new Color32(255, 255, 255, 255);
            select6.SetActive(false);
            Image6.color = new Color32(255, 255, 255, 255);
        }

        if (select.activeInHierarchy == false)
        {
            IsClick = false;
        }

        if (TimerStart == true)
        {
            Timer -= Time.deltaTime;
        }

        if (Timer <= 0)
        {
            Timer = 1;
            TimerStart = false;
            Click = 0;
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

    public void DoubleClicks()
    {
        Click++;

        if (Click == 1)
        {
            TimerStart = true;
        }

        if (Click == 2)
        {
           Folder.SetActive(true); 
        }
    }
}
