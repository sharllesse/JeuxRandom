using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TabApp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject AppSurliner;
    public GameObject OpenTab;
    public void OnPointerEnter(PointerEventData eventData)
    {
        AppSurliner.SetActive(true);
        OpenTab.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        AppSurliner.SetActive(false);
        OpenTab.SetActive(false);
    }
}
